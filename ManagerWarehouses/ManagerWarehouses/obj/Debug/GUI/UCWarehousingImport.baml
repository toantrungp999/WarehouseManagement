   M S B A M L   `   `   `  ����L  HManagerWarehouses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagerWarehouses.GUIManagerWarehouses.GUI  5      /    )ManagerWarehouses.GUI.UCWarehousingImport   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ManagerWarehouses.GUI     5      .��5	      � #��� ��6   .+�5
   
   �� $��23��6   $
��Left=�6    $	��Top=�6;   $-��'Thêm mới, chỉnh sửa mẫu giày:��6S   $��	20,40,0,0q�6x   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Mẫu giày:��6S   $��	20,90,0,0q�6d   6z   �� 5   
   -   5        $��_cbModel��5   +   $��23��6   $	��140��6   $
��Left=�6;   $	��Top=�6V   $��	90,90,0,0q�6n   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Màu:��6S   $��
265,90,0,0q�6_   6v   �� 5   
   -   5        $��_cbColor��5   +   $��23��6   $	��100��6   $
��Left=�6;   $	��Top=�6V   $��
310,90,0,0q�6n   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Cỡ:��6S   $��
445,90,0,0q�6^   6u   �� 5   
   -   5        $��_cbSize��5   +   $��23��6   $	��100��6   $
��Left=�6:   $	��Top=�6U   $��
480,90,0,0q�6m   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Số lượng:��6S   $��
610,90,0,0q�6d   6{   �� 5   
   -   5        $��
_txtAmount��5   c     �� 	MaxLength$  5��6   $��23��6K   $	��100��6W   $
��Left=�6u   $	��Top=�6�   $��
680,90,0,0q�6�   6�   �� 5   
   -   5        $��
_btnAddNew��5      $��23��6$   $	��180��60   $��Center=�6<   $	��Top=�6Y   $��335,145,335,0q�6q   $��Thêm vào danh sách��6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $"��Danh sách các mẫu giày:��6S   $��
20,185,0,0q�6r   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��_dataGridListShoes��5   �   $   HorizontalScrollBarVisibility$ Disabled=�6   $��	0,220,0,0q�6=   $��Center=�6P   $	��Top=�6m      AutoGenerateColumns .  $	��300��6�   $	��650��6�   #��� ��6�   #��� ��6%     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6G      Header$ 	Mã mẫu��6S      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ModelShoes_ID+6c     5      $	 170 6D   $ 
Tên mẫu��6P    .  6%   �� *
NameShoese+6a     5      $	 100 6?   $
 Màu��6K    .  6%   �� *Color+6X     5      $	 100 6>   $
 Cỡ��6J    .  6%   �� *Size+6V     5      $	 100 6@   $ Số lượng��6L    .  6%   �� *Amount+6^   4  .System.Windows.Controls.DataGridTemplateColumn  5      $ 80 6)      CellTemplate 5      �� 5      .R�5      �� -   5        .��5   4   Xóa69   5       5"      5$      �� 5%   
   $��23��6   $��	Ghi chú:��6    $��100,560,0,0q�60   $
��Left=�6E   $	��Top=�6`   6z   �� 5&   
   -   5        $��_txtContent��5&      $��40��6%   $	��360��61   $��160,550,0,0q�6=   $
��Left=�6R   $	��Top=�6m   6�   �� 5'   
   -	   5        $��_btnAddWarehousing��5'      $��23��6,   $	��180��68   $
��Left=�6D   $	��Top=�6_   $��560,560,0,0q�6w   $��Thêm vào kho��6�   6�   5(      5)      