   M S B A M L   `   `   `  ����L  HManagerWarehouses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagerWarehouses.GUIManagerWarehouses.GUI  5      0    *ManagerWarehouses.GUI.UCWarehousingDetails   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ManagerWarehouses.GUI     5      .��5	      � #��� ��6   .+�5
   
   �� $��32��6   $	��Top=�6    $��Center=�68   $��0,20,0,0q�6U   $��Chi tiết nhập kho��6h   $��24(�6�   $��ExtraCondensed&�6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Thông tin nhập kho:��6S   $��	20,70,0,0q�6n   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Mã nhân viên:��6S   $��
20,120,0,0q�6h   6   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��	Ghi chú:��6S   $��
20,180,0,0q�6c   6z   �� 5   
   -   5        $��_txtEmployee_id��5   <   $��23��6     �� 
IsReadOnly  . $	��100��60   $
��Left=�6S   $	��Top=�6n   $��120,120,0,0q�6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Tên nhân viên:��6S   $��300,120,0,0q�6i   6�   �� 5   
   -   5        $��_txtFullName��5   <   $��23��6     . $	��100��60   $
��Left=�6P   $	��Top=�6k   $��400,120,0,0q�6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Ngày��6S   $��600,120,0,0q�6_   6w   �� 5   
   -   5        $��_txtDate��5   J    �� 	MaxLength$ 5��6     . $��23��62   $	��100��6>   $
��Left=�6Z   $	��Top=�6u   $��640,120,0,0q�6�   6�   �� 5   
   -   5        $��_txtNote��5   J   $ 5��6     . $��60��62   $	��620��6>   $
��Left=�6Z   $	��Top=�6u   $��120,160,0,0q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��_dataGridListShoes��5   �   $   HorizontalScrollBarVisibility$ Disabled=�6   $��140,250,140,0q�6=   $��Center=�6T   $	��Top=�6q      AutoGenerateColumns .  $	��300��6�   $	��570��6�   #��� ��6�   #��� ��6)     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6B      Header$ 	Mã giày��6N      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Shoes_ID+6_     5      $	 170 6G   $ 	Mã mẫu��6S    .  6%   �� *ModelShoes_ID+6c     5      $	 100 6?   $
 Màu��6K    .  6%   �� *Color+6X     5      $	 100 6>   $
 Cỡ��6J    .  6%   �� *Size+6V     5      $	 100 6@   $ Số lượng��6L    .  6%   �� *Amount+6^   5      �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��140,580,0,0q�6S   $��Ghi chú��6h   6y   �� 5   
   -   5        $��_txtNoteDelete��5   �   $��40��6   $	��180��6   {�.  $
��Left=�6<   $	��Top=�6W   $��200,570,0,0q�6o   6�   �� 5   
   -   5        $��
_btnDelete��5      $��23��6$   $	��180��60   $
��Left=�6<   $	��Top=�6W   $��560,580,0,0q�6o   $��Xóa bảng nhập này��6�   6�   5!      5"      