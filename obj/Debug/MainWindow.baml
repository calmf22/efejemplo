   M S B A M L   `   `   `  ����H  Ddemobasedatos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:demobasedatosdemobasedatos  5   	       demobasedatos.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:demobasedatos     5   	   -   5          � Title$  
MainWindow��5   	   $	��350��6   $	��761��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ button��5
      $��Guardar��6!   $
��Left=�63   $��
384,18,0,0q�6N   $	��Top=�6b   $��90��6z   $��34��6�   6�   �� 5   
   -   5         ��Name$ 	txtnombre��5      $
��Left=�6%   $��23��6@   $��	69,59,0,0q�6L    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ 	txtsueldo��5      $
��Left=�6%   $��23��6@   $��	69,90,0,0q�6L   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5         ��Name$ label��5      $��Nombre��6   $
��Left=�60   $��	10,56,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ label1��5      $��Saldo��6    $
��Left=�60   $��	10,87,0,0q�6K   $	��Top=�6^   �� 5   
   -   5        $ 	textBoxID��5      $
��Left=�6%   $��23��6@   $��	54,21,0,0q�6L   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ label2��5      $��ID��6    $
��Left=�6-   $��	27,18,0,0q�6H   $	��Top=�6[   �� 5   
   -	   5        $ button1��5      $��
Actualizar��6"   $
��Left=�67   $��34��6R   $��
494,18,0,0q�6^   $	��Top=�6r   $	��100��6�   6�   �� 5   
   -
   5        $ button2��5      $��Borrar��6"   $
��Left=�63   $��34��6N   $��
608,18,0,0q�6Z   $	��Top=�6n   $	��100��6�   6�   �� 5   
   -   5        $ button3��5      $��Consultar por ID��6"   $
��Left=�6=   $��35��6X   $��
384,62,0,0q�6d   $	��Top=�6x   $	��139��6�   6�   �� 5   
   -   5        $ button4��5      $��Consultar todo��6"   $
��Left=�6;   $��35��6V   $��
569,62,0,0q�6b   $	��Top=�6v   $	��139��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DBgrid��5      $
��Left=�6#   $��272,156,0,0q�6>   $	��Top=�6S   $	��133��6k   $	��300��6x   �� 5   
   -   5        $ label3��5      $��Departamento��6    $
��Left=�67   $��
10,134,0,0q�6R   $	��Top=�6f   �� 5   
   -   5         ��Name$ CBDeps��5      $
��Left=�6#   $��102,138,0,0q�6>   $	��Top=�6S   $	��120��6k   5      5      