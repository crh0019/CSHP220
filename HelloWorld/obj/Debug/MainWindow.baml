   M S B A M L   `   `   `  ����E  AHelloWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:HelloWorld
HelloWorld  5   	       HelloWorld.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:HelloWorld     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5
      �� -   5         ��Name$ uxContainer��5
      .+�5   
   �� Enter Name:6!   �� 5   
   -   5         ��Name$ uxName��5      ��5   	   �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . .��6`   5      �� 5   
   -   5         ��Name$ uxNameError��5      ��5      �� *	NameError+$ PropertyChanged=�6R   �� 5   
   Enter Password:6%   �� 5   
   -   5        $ 
uxPassword��5      ��5   	   �� *
Password+$ PropertyChanged=� . .��6d   5      �� 5   
   -   5        $ uxPasswordError��5      ��5      �� *PasswordError+$ PropertyChanged=�6V   �� 5   
   -   5         ��Name$ uxSubmit��5      .��6:   Submit��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      �� 5      	 �� Binding	 6&   �� *Text.Length+
 �� ElementName$
 uxName��$ PropertyChanged=� �� Value 06   .a�5      ��  �� Property � {� �� Value .  6:   5      �� 5       	 6&   �� *Text.Length+$
 
uxPassword��$ PropertyChanged=� 06�   .a�5!      ��  � {� .  6:   5"      5$      5&      �� 5(   
   .��5)      ��  �� Orientation$ 
Horizontal=�6   .+�5*      �� $*��$Images/ic_thumb_up_black_24dp_2x.png��6   $��0,0,10,0q�6F   �� 5+      $��Center=�6   $��	Thumbs Up��67   5,      5-      5/      50      