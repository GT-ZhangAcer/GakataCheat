
# GakataCheat
机房控制工具

---项目概述
没啥用，自己上课无聊玩的，仅限使用伽卡他卡学生端的机房使用
该工具目前V1.01版本仅有3个功能
1.在学生端就可以锁定其它学生机器的“锁定屏幕”功能
2.有锁定就有解锁对不对？
3.无意间发现可以学生端发文字消息（目前不支持中文，不知道编码上出现了什么问题）
该工具目前有两个版本
1.Python版 写GUI写了好长时间，这点真的不如C#来得快
2.C#版 上课空闲时间顺手写出来的，很快 界面也好看 就是在测试时候老师把教师端关闭了，又赶上期末，也去不了机房，没测试。
---目录结构
venv虚拟环境
在目录ControlGakta中有C#版本源码
EXE.txt为打包工具指令，需要下载对应的包
原始文件中有Wireshark抓到的数据包
ico文件为图标文件，不可缺少
MainScript为脚本源码
Main为GUI界面
Main_support为TK自动生成的代码
---所需包
无
---已知Bug
功能3-发送消息 使用中文会乱码
教师端没有开放，该程序就是个废物
---注意事项
锁定同学的机器时，提前做好挨打的准备
锁定老师机器时，请提前在教师机安装学生端
骂人要注意点，对方虽然没办法回复你，但他万一回复到教师端就有点东西了
表白不用写自己名字，替别人表白要先把自己IP地址换掉，不然对方是可以顺着网线找到你的。
---版本历史
Python版
2018.12.31 V1.01第一版
C#版
2018.12.31 V1.01第一版
