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
   -   5        $��SearchPatientsBox��5#   L   $��23��6   $
��Left=�6   $��	26,30,0,0q�69   $	��Top=�5$      $	��174��6*   *   $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Search��66   ��5%      �� *
SearchWord+$ TwoWay=��� 5&   
   -   5        $��FilterPatientsComboBox��5&   N   $��23��6   $
��Left=�6   $��
310,30,0,0q�6:   $	��Top=�5'      $	��120��6+    �� SelectedValuePath$ Content��5(       �� SelectedValue 5'   7   �� *FilterSearch+.@�5)      ��  �� 
IsSelected . .��6-   	Firstname68   �� 5*      .��6   
Lastname6%   �� 5+      .��6   Phone Number6)   �� 5,      .��6   Role6!   �� 5-      .��6   Date Of Birth6*   �� 5.      .��6   City6!   5/      �� 50   
   -   5        $��Label1��50   _   $��	Filter By��6   $��26��6$   $
��Left=�60   $��
224,30,0,0q�6K   $	��Top=�51      $��83��6(   �� 52   
   -   5        $��QueryPatientsResult��52   K   $��25��6   $
��Left=�6   $��
26,436,0,0q�67   $	��Top=�53      $	��174��6(   �� 54   
   $��50��6   $��50��6     MetroCircleButtonStyle#���  6(   $��0,20,150,500q�6Y   $��Right=�55      $��Bottom=�6-   ��6H   �� *ToAddTabCommand+.��56      �� $��25��6   $��25��6#   ��57      ��  �� Path$ 
Foreground� �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 58      !� 59       j� Stretch$
 Fill=�6"     appbar_user_add !� Visual# �  61   5;      5<      �� 5=   
   $��50��6   $��0,20,100,500q�6   #���  63   $��50��6d   $��Right=�5>      ��6-   �� *RemoveCommand+.��5?      �� $��25��5A      $��25��6   ��5@      �� $ 
Foreground� �� *FindAncestor+" �� 5B      !� 5C      $
 Fill=�6"     appbar_user_minus# �  61   5E      5F      �� 5G   
   $��50��6   $��0,20,50,500q�6   #���  62   $��50��6c   $��Right=�5H      ��6-   �� *ToEditTabCommand+.��5I      �� $��25��5K      $��25��6   ��5J      �� $ 
Foreground� �� *FindAncestor+" �� 5L      !� 5M      $
 Fill=�6"     appbar_edit# �  61   5O      5P      5Q      5S      