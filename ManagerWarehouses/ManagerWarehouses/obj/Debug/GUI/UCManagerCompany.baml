   M S B A M L   `   `   `  ����L  HManagerWarehouses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagerWarehouses.GUIManagerWarehouses.GUI  5      ,    &ManagerWarehouses.GUI.UCManagerCompany   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ManagerWarehouses.GUI     5      .��5	      � #��� ��6   .+�5
   
   �� $��32��6   $	��Top=�6    $��Center=�68   $��0,20,0,0q�6U   $��Quản lý hãng giày��6h   $��24(�6�   $��ExtraCondensed&�6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $'��!Thêm mới, chỉnh sửa hãng:��6S   $��	20,70,0,0q�6t   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Tên hãng:��6S   $��240,120,0,0q�6d   6|   �� 5   
   -   5        $��_txtName��5   *   $��23��6   $	��250��6   $
��Left=�6:   $	��Top=�6U   $��320,120,0,0q�6m   6�   �� 5   
   -   5        $��
_btnAddNew��5      $��23��6$   $	��120��60   $��Center=�6<   $	��Top=�6Y   $��	0,180,0,0q�6q   $��Thêm mới hãng��6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Danh sách các hãng:��6S   $��
20,210,0,0q�6n   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��_dataGridCompany��5   �   $    HorizontalScrollBarVisibility$  Disabled=�6   $��200,250,200,0q�6<   $��Center=�6S   $	��Top=�6p      AutoGenerateColumns .  $	��300��6�   $	��450��6�   #��� ��6�   #��� ��6&     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6)      CellTemplate 5      �� 5      .R�5      �� -   5        .��5   4   Xóa69   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $	 100 6E      Header$ 	Mã hãng��6Q      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Companny_ID+6b     5      $	 250 6E   $ 
Tên hãng��6Q    .  6%   �� *CompanyName+6c   5      5      5      