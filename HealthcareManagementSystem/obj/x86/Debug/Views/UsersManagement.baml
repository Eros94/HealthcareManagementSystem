   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       HealthcareManagementSystem6   0HealthcareManagementSystem.Views.UsersManagement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$"  Healthcare Management System��5      $	��600��5      $	��800��5       � 
ResizeMode$ CanResizeWithGrip=�5         AccentColorBrush(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush# �   5	       � 	Resources 5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ /Resources/Icons.xaml?�6%   %    5      .��5      � -   5        $��UsersManagementGrid��5      $	��570��6   $	��790��63   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��	UsersGrid��5         AutoGenerateColumns .  $	��300��5   /   $
��Left=�6<   $��0,94,0,0q�6W   $	��Top=�5   $   $	��790��6<   
���������6[   �� *Users+ �� SelectedItem 5      �� *SelectedUser+ �� Mode$ TwoWay=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 	Firstname��6C   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Fisrtname+6C     5      $
 LastName��6B    6%   �� *
Lastname+6B     5      $	
 CIN��6=    6%   �� *CIN+6=     5      $
 Phone Number��6E    6%   �� *PhoneNumber+6E     5      $

 Role��6>    6%   �� *Role+6>     5      $
 Date Of Birth��6E    6%   �� *DateOfBirth+6E     5      $

 City��6G    6%   �� *City.CityName+6G   5       �� 5!   
   -   5        $��Button1��5!   b   $��
Get Result��6   $��23��6&   $
��Left=�62   $��465,436,0,0q�6M   $	��Top=�5"      $��75��6)   ��64   �� *GetListUsersCommand+�� 5#   
   -   5        $��SearchPatientsBox��5#   M   $��23��6   $
��Left=�6   $��
115,34,0,0q�69   $	��Top=�5$      $	��174��6*   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Search��66   ��5%      �� *
SearchWord+$ TwoWay=��� 5&   
   -   5        $��FilterPatientsComboBox��5&   N   $��23��6   $
��Left=�6   $��
399,34,0,0q�6:   $	��Top=�5'      $	��120��6+    �� SelectedValuePath$ Content��5(       �� SelectedValue 5'   7   �� *FilterSearch+.@�5)      ��  �� 
IsSelected . .��6-   	Firstname68   �� 5*      .��6   
Lastname6%   �� 5+      .��6   Phone Number6)   �� 5,      .��6   Role6!   �� 5-      .��6   Date Of Birth6*   �� 5.      .��6   City6!   5/      �� 50   
   -   5        $��Label1��50   _   $��	Filter By��6   $��26��6$   $
��Left=�60   $��
313,34,0,0q�6K   $	��Top=�51      $��83��6(   �� 52   
   $��50��6   $��0,20,200,500q�6     MetroCircleButtonStyle#���  63   $��50��6d   $��Right=�53      ��6-   �� *ToAddAppointmentTabCommand+.��54      �� $��29��56      $��22��6   ��55      ��  �� Path$ 
Foreground� �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 57      !� 58       j� Stretch$
 Fill=�6"     appbar_clipboard_edit !� Visual# �  61   5:      5;      �� 5<   
   $��50��6   $��50��6   #���  6(   $��0,20,150,500q�6Y   $��Right=�5=      $��Bottom=�6-   ��6H   �� *ToAddTabCommand+.��5>      �� $��25��6   $��25��6#   ��5?      �� $ 
Foreground� �� *FindAncestor+" �� 5@      !� 5A      $
 Fill=�6"     appbar_user_add# �  61   5C      5D      �� 5E   
   $��50��6   $��0,20,100,500q�6   #���  63   $��50��6d   $��Right=�5F      ��6-   �� *RemoveCommand+.��5G      �� $��25��5I      $��25��6   ��5H      �� $ 
Foreground� �� *FindAncestor+" �� 5J      !� 5K      $
 Fill=�6"     appbar_user_minus# �  61   5M      5N      �� 5O   
   $��50��6   $��0,20,50,500q�6   #���  62   $��50��6c   $��Right=�5P      ��6-   �� *ToEditTabCommand+.��5Q      �� $��25��5S      $��25��6   ��5R      �� $ 
Foreground� �� *FindAncestor+" �� 5T      !� 5U      $
 Fill=�6"     appbar_edit# �  61   5W      5X      �� 5Y   
   -   5        $��button2��5Y   �   $
��Back��69   $��23��6H   $
��Left=�6T   $��	12,32,0,0q�6o   $	��Top=�6�   $��75��6�   ��6   �� *ToAdminPanelCommand+6�   5Z      5\      