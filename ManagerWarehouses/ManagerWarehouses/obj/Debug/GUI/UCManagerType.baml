   M S B A M L   `   `   `  ����L  HManagerWarehouses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagerWarehouses.GUIManagerWarehouses.GUI  5      )    #ManagerWarehouses.GUI.UCManagerType   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ManagerWarehouses.GUI     5      .��5	      � #��� ��6   .+�5
   
   �� $��32��6   $	��Top=�6    $��Center=�68   $��0,20,0,0q�6U   $��Quản lý loại giày��6h   $��24(�6�   $��ExtraCondensed&�6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $.��(Thêm mới, chỉnh sửa loại giày:��6S   $��	20,70,0,0q�6y   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Loại giày:��6S   $��240,120,0,0q�6e   6}   �� 5   
   -   5        $��_txtName��5   *   $��23��6   $	��250��6   $
��Left=�6:   $	��Top=�6U   $��320,120,0,0q�6m   6�   �� 5   
   -   5        $��
_btnAddNew��5      $��23��6$   $	��120��60   $
��Left=�6<   $	��Top=�6W   $��270,180,0,0q�6o   $��Thêm mới loại��6�   6�   �� 5   
   -   5        $��
_btnUpdate��5      $��23��6%   $	��120��61   $
��Left=�6=   $	��Top=�6X   $��470,180,0,0q�6p   $��Cập nhật loại��6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $#��Danh sách các loại giày:��6S   $��
20,210,0,0q�6s   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��_dataGridTypeShoes��5   �   $    HorizontalScrollBarVisibility$  Disabled=�6   $��200,250,195,0q�6=   $��Center=�6T   $	��Top=�6q      AutoGenerateColumns .  $	��300��6�   $	��455��6�   #��� ��6�   #��� ��6)     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6A      Header$ 
Mã loại��6M      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *	Type_ID+6^     5      $	 250 6B   $ Tên loại��6N    .  6%   �� *
TypeName+6`   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 100 6)      CellTemplate 5      �� 5      .R�5      �� -   5        .��5   4   Xóa69   5      5      5      5      5       