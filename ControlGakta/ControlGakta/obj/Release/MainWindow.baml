   M S B A M L   `   `   `  ���� G  CControlGakta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ControlGaktaControlGakta      ControlGakta.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:ControlGakta       � Title$#  机房控制系统V1.01 C#版��$��326.584��$��425.176�� � Icon$/ )pack://siteoforigin:,,,/Resources/ico.ICO��.��� $��0,0,2,0q�.+��� -    ��Name$ id��$
��Left=�$��23��$��
113,13,0,0q� �� TextWrapping$
 Wrap=�$	��200��$	��Top=�$	��120���� -    ��Name$ label��$��目标机位号：��$
��Left=�$��	26,10,0,0q�$	��Top=��� -    ��Name$ groupBox��$��GroupBox��$
��Left=�$	��167��$��
26,119,0,0q�$	��Top=�$	��355��.��� $
��Left=�$	��135��$��10,0,0,0q�$	��Top=�$	��332��.+��� -    ��Name$ button��$��执行指令��$
��Left=�$��28��$��
206,91,0,0q�$	��Top=�$��92��	� -    	�Name$ radioButton1��$��锁定屏幕��$
��Left=�$��	21,20,0,0q�$	��Top=� d� 	IsChecked$
 TrueY�	 	� 	GroupName$		 num��	� -   $ radioButton2��$��解锁屏幕��$
��Left=�$��	21,62,0,0q�$	��Top=�$		 num��	� -   $ radioButton3��$��发送消息��$
��Left=�$��
21,103,0,0q�$	��Top=�$		 num���� -   
 ��Name$
 	textBlock��$
��Left=�$��
178,20,0,0q�$
��Wrap=�$��高级参数设定：��$	��Top=��� -	   $	 Op1��$
��Left=�$��23��$��
178,41,0,0q�$
 Wrap=�$��
0650005000��$	��Top=�$	��120���� -
   $ text1��$
��Left=�$��23��$��
113,47,0,0q�$
 Wrap=�$��Hello��$	��Top=�$	��268���� -   $ 
label_Copy��$��待发送消息：��$
��Left=�$��	26,43,0,0q�$	��Top=��� -   $ label_Copy1��$��你的机位号：��$
��Left=�$��	26,79,0,0q�$	��Top=��� -   $ IDSend��$
��Left=�$��23��$��
113,81,0,0q�$
 Wrap=�$��1��$	��Top=�$��52���� -   $ button1��$��关于��$
��Left=�$��
306,88,0,0q�$	��Top=�$��75��