#include "reg52.h"
#include <intrins.H>


#define uchar unsigned char 	//�궨���ַ��ͱ���
#define uint  unsigned int    //�궨�����ͱ���
	

#define BAUD 	0XFE80  				//9600bps@ 11.0592MHZ

sfr AUXR = 0x8E;   						//�����Ĵ���
sbit RXB = P3^0;
sbit TXB = P3^1;
sbit P33 = P3^3; 							//����̵������������
uchar dat; 										//���ڴ洢��Ƭ�����շ��ͻ���Ĵ���SBUF���������

uchar TBUF, RBUF;
uchar TDAT, RDAT;
uchar TCNT, RCNT;
uchar TBIT, RBIT;
uint TING, RING;
uint TEND, REND;

void UART_INIT(); 		//��������

uchar t, r;          	//������������
uchar but[16];      	//���ݴ洢����

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
    TMOD = 0X00;       //��ʱ��T0�趨
    AUXR = 0X80;       //�����Ĵ���
    TL0 = BAUD;       //ʮ��λ�Ĵ���
    TH0 = BAUD >> 8;   //ʮ��λ�Ĵ���
    TR0 = 1;           //����ʱ��
    ET0 = 1;
    PT0 = 1;
    EA = 1;           //�����ж�
	  
    UART_INIT();   //���ڳ�ʼ��
    while (1)       //����ѭ��
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
                switch (dat) //���������ж�
                {
                case 'A': P33 = 1; delay(k); TBUF = dat; dat = 0xee; break;       //  ��������������ֵ
                case 'B': P33 = 0; delay(k); TBUF = dat; dat = 0xee; break;       //  �أ�����������ֵ
                case 'C': if (P33 == 1) { TBUF = 'A'; }if (P33 == 0) { TBUF = 'B'; }delay(k); dat = 0xee; break;       //  �������״̬������������ֵ
                case 'D': P33 = !P33; delay(k); TBUF = dat; dat = 0xee; break;  //  �����ȡ��
                default:break;                       //  ����
                }
                t++;
                //TBUF=but[t++&0x0f];
                TING = 1;
            }
        }
    }
}

/********************************************************************
                            ��ʱ��T0
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