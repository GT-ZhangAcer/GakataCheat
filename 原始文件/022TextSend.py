import socket

def broad(client_IP,client_Point,text):#setting为0时为停止广播，1为开始广播
    client_socket=socket.socket(socket.AF_INET,socket.SOCK_DGRAM)#绑定socket
    server_address=(client_IP,client_Point)#绑定服务器地址以及端口
    client_socket.sendto(text.encode(),server_address)
    print("数据包发送---OK")
    client_socket.close()

def CMDMain():
    client_ID=input("输入机位号_")
    text=input("请输入消息\n消息内容_")
    client_IP="192.168.1."+client_ID
    client_Point=5000
    broad(client_IP,client_Point,text)
    print("操作完成-----OK")

while(1):
    CMDMain()
