   M S B A M L   `   `   `  ����L  HManagerWarehouses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ManagerWarehouses.GUIManagerWarehouses.GUI  5      *    $ManagerWarehouses.GUI.UCManagerModel   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:ManagerWarehouses.GUI     5      .��5	      � #��� ��6   .+�5
   
   �� $��32��6   $	��Top=�6    $��Center=�68   $��0,25,0,0q�6U   $��Quản lý mẫu giày��6h   $��24(�6�   $��ExtraCondensed&�6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $-��'Thêm mới, chỉnh sửa mẫu giày:��6S   $��	20,70,0,0q�6x   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Mẫu giày:��6S   $��
20,120,0,0q�6d   6{   �� 5   
   -   5        $��_txtName��5   *   $��23��6   $	��160��6   $
��Left=�6:   $	��Top=�6U   $��120,120,0,0q�6m   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Loại giày:��6S   $��300,120,0,0q�6e   6}   �� 5   
   -   5        $��_cbType��5   +   $��23��6   $	��160��6   $
��Left=�6:   $	��Top=�6U   $��360,120,0,0q�6m   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $��Hãng giày:��6S   $��540,120,0,0q�6e   6}   �� 5   
   -   5        $��
_cbCompany��5   +   $��23��6   $	��160��6   $
��Left=�6=   $	��Top=�6X   $��610,120,0,0q�6p   6�   �� 5   
   -   5        $��
_btnAddNew��5      $��23��6$   $	��120��60   $
��Left=�6<   $	��Top=�6W   $��270,180,0,0q�6o   $��Thêm mới mẫu��6�   6�   �� 5   
   -   5        $��
_btnUpdate��5      $��23��6%   $	��120��61   $
��Left=�6=   $	��Top=�6X   $��470,180,0,0q�6p   $��Cập nhật mẫu��6�   6�   �� 5   
   $��23��6   $
��Left=�6    $	��Top=�6;   $"��Danh sách các mẫu giày:��6S   $��
20,210,0,0q�6r   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��_dataGridModelShoes��5   �   $    HorizontalScrollBarVisibility$  Disabled=�6   $��100,250,100,0q�6<   $	��Top=�6S      AutoGenerateColumns .  $	��300��6�   $	��650��6�   #��� ��6�   #��� ��6     Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6)      CellTemplate 5      �� 5      .R�5      �� -   5        .��5   4   Xóa69   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $	 100 6G      Header$ 	Mã mẫu��6S      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ModelShoes_ID+6c     5      $	 170 6D   $ 
Tên mẫu��6P    .  6%   �� *
NameShoese+6a     5       $	 150 6B   $ Tên loại��6N    .  6%   �� *
TypeName+6`     5!      $	 150 6E   $ Tên công ty��6Q    .  6%   �� *CompanyName+6f   5$      5&      5'      