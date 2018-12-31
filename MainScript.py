import socket

def textsend(client_IP,client_Point,text):#setting为0时为停止广播，1为开始广播
    client_socket=socket.socket(socket.AF_INET,socket.SOCK_DGRAM)#绑定socket
    server_address=(client_IP,client_Point)#绑定服务器地址以及端口
    client_socket.sendto(text.encode(),server_address)
    print("数据包发送---OK")
    client_socket.close()

def broad(client_IP,client_Point,setting):#setting为0时为停止广播，1为开始广播
    client_socket=socket.socket(socket.AF_INET,socket.SOCK_DGRAM)#绑定socket
    msgstart = "STARTBROAD|1"#Data 广播指令
    msgstop = "STOPBROAD"#Data 关闭指令
    server_address=(client_IP,client_Point)#绑定服务器地址以及端口
    if(setting==1):
        client_socket.sendto(msgstart.encode(),server_address)
    else:
        client_socket.sendto(msgstop.encode(),server_address)
    print("数据包发送---OK")
    client_socket.close()

