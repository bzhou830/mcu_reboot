#include "reg52.h"
#include <intrins.H>


#define uchar unsigned char 	//宏定义字符型变量
#define uint  unsigned int    //宏定义整型变量
	

#define BAUD 	0XFE80  				//9600bps@ 11.0592MHZ

sfr AUXR = 0x8E;   						//辅助寄存器
sbit RXB = P3^0;
sbit TXB = P3^1;
sbit P33 = P3^3; 							//定义继电器控制输出脚
uchar dat; 										//用于存储单片机接收发送缓冲寄存器SBUF里面的内容

uchar TBUF, RBUF;
uchar TDAT, RDAT;
uchar TCNT, RCNT;
uchar TBIT, RBIT;
uint TING, RING;
uint TEND, REND;

void UART_INIT(); 		//声明函数

uchar t, r;          	//定义数据类型
uchar but[16];      	//数据存储数组

void delay(uchar t)
{
    uchar i, j;
    for (i = 0; i < t; i++)
    {
        for (j = 13; j > 0; j--);
        {;
        }
    }
}

void main() {
    TMOD = 0X00;       //定时器T0设定
    AUXR = 0X80;       //辅助寄存器
    TL0 = BAUD;       //十六位寄存器
    TH0 = BAUD >> 8;   //十六位寄存器
    TR0 = 1;           //开定时器
    ET0 = 1;
    PT0 = 1;
    EA = 1;           //开总中断
	  
    UART_INIT();   //串口初始化
    while (1)       //无线循环
    {
        if (REND)
        {
            REND = 0;
            r++;
            //but[r++&0x0f]=RBUF;
            dat = RBUF;
        }
        if (TEND)
        {
            if (t != r)
            {
							uchar k;
							k = 10;
                TEND = 0;
                //TBUF=dat;
                switch (dat) //接收数据判断
                {
                case 'A': P33 = 1; delay(k); TBUF = dat; dat = 0xee; break;       //  开，并返回数据值
                case 'B': P33 = 0; delay(k); TBUF = dat; dat = 0xee; break;       //  关，并返回数据值
                case 'C': if (P33 == 1) { TBUF = 'A'; }if (P33 == 0) { TBUF = 'B'; }delay(k); dat = 0xee; break;       //  读输出口状态，并返回数据值
                case 'D': P33 = !P33; delay(k); TBUF = dat; dat = 0xee; break;  //  输出口取反
                default:break;                       //  跳出
                }
                t++;
                //TBUF=but[t++&0x0f];
                TING = 1;
            }
        }
    }
}

/********************************************************************
                            定时器T0
*********************************************************************/
void tm0()interrupt 1 using 1
{
    if (RING)
    {
        if (--RCNT == 0)
        {
            RCNT = 3;
            if (--RBIT == 0)
            {
                RBUF = RDAT;
                RING = 0;
                REND = 1;
            }
            else
            {
                RDAT >>= 1;
                if (RXB)RDAT |= 0X80;
            }

        }
    }
    else if (!RXB)
    {
        RING = 1;
        RCNT = 4;
        RBIT = 9;
    }
    if (--TCNT == 0)
    {
        TCNT = 3;
        if (TING)
        {
            if (TBIT == 0)
            {
                TXB = 0;
                TDAT = TBUF;
                TBIT = 9;
            }
            else
            {
                TDAT >>= 1;
                if (--TBIT == 0)
                {
                    TXB = 1;
                    TING = 0;
                    TEND = 1;
                }
                else
                {
                    TXB = CY;
                }
            }
        }
    }
}

void UART_INIT()
{
    TING = 0;
    RING = 0;

    TEND = 1;
    REND = 0;

    TCNT = 0;
    RCNT = 0;
}