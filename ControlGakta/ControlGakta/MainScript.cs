using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//额外添加引用
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ControlGakta
{
    class MainScript
    {
        public string ID;//机位号
        public string port1;
        public string port2;
        public string ID2;//发送者ID
        public string sendtext;
        public int selent;//选择的命令
        public MainScript(int sselent,string sID,string sID2,string sport1,string sport2,string stext)
        {
            selent = sselent;
            ID = sID;
            ID2 = sID2;
            port1 = sport1;
            port2 = sport2;
            sendtext = stext;

        }
        public void broad()//
        {
            IPEndPoint localIpep = new IPEndPoint(IPAddress.Parse("192.168.1."+ID2), int.Parse(port1));//绑定发送方IP地址以及端口
                                                                                                       //UdpClient udpClient = new UdpClient(localIpep);//匿名发送在n创建实例中参数设置为0即可
            UdpClient udpClient = new UdpClient(0); //匿名发送
                                                           //Thread thrSend = new Thread(SendMessage);
            string message = "";
            if (selent == 1)
            {
                message = "STARTBROAD|1";
            }
            else
            {
                message = "STOPBROAD";
            }   
            byte[] sendbytes = Encoding.ASCII.GetBytes(message);
            IPEndPoint remoteIpep = new IPEndPoint(IPAddress.Parse("192.168.1."+ID), int.Parse(port1));
            udpClient.Send(sendbytes, sendbytes.Length, remoteIpep);
            udpClient.Close();
        }
        public void sendtextScript()
        {
            IPEndPoint localIpep = new IPEndPoint(IPAddress.Parse("192.168.1." + ID2), int.Parse(port2));//绑定发送方IP地址以及端口
            UdpClient udpClient = new UdpClient(0);
            string message = sendtext;
            byte[] sendbytes = Encoding.ASCII.GetBytes(message);
            IPEndPoint remoteIpep = new IPEndPoint(IPAddress.Parse("192.168.1." + ID), int.Parse(port2));
            udpClient.Send(sendbytes, sendbytes.Length, remoteIpep);
            udpClient.Close();
        }
    }
}
