   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      U QHealthcareManagementSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null[2clr-namespace:HealthcareManagementSystem.Utilities$HealthcareManagementSystem.Utilities 5      1   +HealthcareManagementSystem.Authentification   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      H	utilities2clr-namespace:HealthcareManagementSystem.Utilities     5        � Title$"  Healthcare Management System��5      $	��600��5      $	��800��5       � 
ResizeMode$ CanResizeWithGrip=�5	         AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5
      .��5      � -   5        $��grid1��5      $	��575��6   $	��790��6%    � ColumnDefinitions 5   
   �� 5      $	��90* �6   �� 5      $
��190* �6   �� 5      $
��250* �6   �� 5      $
��260* �6    � RowDefinitions 5   
   �� 5      $
��180* �6   �� 5      $	��40* �6   �� 5      $	��11* �6   �� 5      $	��40* �6   �� 5      $
��304* �6   .+�5   
   �� -   5        $��label1��5   X   $��	Username:��6   $��1��6$   $��40��61   $
��Left=�6=   $	��Top=�5      $	��190��6(   $��1��64   �� 5   
   -   5        $��label2��5   K   $��	Password:��6   $��40��6$   $
��Left=�60   $	��Top=�6Y   $	��190��5      $��1��6   $��3��6,   G� 5   
   -   5        $��passwordBox1��5   Z   $��2��6   $��3��6&   $��40��63   $
��Left=�6?   $	��Top=�5       $	��250��6.   ?  9HealthcareManagementSystem.Utilities.PasswordBoxAssistant   BindPassword .    BoundPassword 5!      ��  �� Path$ Password� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=��� 5"   
   -   5        $��textBox1��5"   V   $��2��6   $��1��6"   $��40��6/   $
��Left=�6;   $	��Top=�5#      $	��250��6*   ��66   �� *Login+�� 5$   
   -   5        $��button1��5%      $��Login��5$      $��2��6!   $��4��61   $��40��6>   $
��Left=�6J   $��0,45,0,0q�6e   $	��Top=�5%       $	��110��68   ��6D   �� *AuthCommand+�� 5&   
   -   5        $��button2��5&   \   $��Clear��6   $��40��6!   $
��Left=�6-   $��
140,45,0,0q�6H   $	��Top=�5'      $	��110��6)   $��2��65   $��4��6E   ��6R   �� *ClearCommand+5(      5)      