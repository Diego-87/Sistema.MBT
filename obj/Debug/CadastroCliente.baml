   M S B A M L   `   `   `  ����  Sistema    Sistema.CadastroCliente   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5        $	��700��5      $
��1200��6'     � 
ResizeMode$  NoResize=�64    � WindowStartupLocation$ CenterScreen=�6J    � WindowStyle$
 None=�6o    � AllowsTransparency . ��5      �� 5   
    �� EndPoint$ 0.5,1&�6    �� 
StartPoint$ 0.5,0&�6/   .��5	      �  � Color$ White��6    � Offset$ 0Q�6)   � 5
      $ 
WhiteSmoke��6   $ 1Q�6.   5      .��5      �  J� RenderTransformOrigin$ 0.82,0.6&�6   	 � ColumnDefinitions	 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� 
�������$
��Left=�6'   $	��245��6B   $��	55,75,0,0q�6O   
�������$	��Top=�6q   $	��845��6�   �� 5   
   -   5        
 ��Name$
 txtendereco��5      $��	ENDEREÇO��6%   $
��Left=�68   $��times new roman)�6S   
�������$��416,133,0,0q�6�   $	��Top=�6�   $ -0.263,0&�6�   $��24��6�   $��74��6�   �� 5   
   -   5        $
 txtnome��5      $��NOME FANTASIA��6!   $��times new roman)�69   $
��Left=�6W   $��
184,90,0,0q�6r   $	��Top=�6�   $ -0.263,0&�6�   $��24��6�   $	��106��6�   �� 5   
   -   5        $
 	txtbairro��5      $��BAIRRO��6#   $��times new roman)�64   $
��Left=�6Q   $��
64,174,0,0q�6l   $	��Top=�6�   $ -0.263,0&�6�   $��24��6�   $��55��6�   �� 5   
   -   5        $
 txtmunicipio��5      $��
MUNICÍPIO��6&   $
��Left=�6:   $��times new roman)�6U   $��345,174,0,0q�6r   $	��Top=�6�   $ -0.263,0&�6�   $��24��6�   $��73��6�   �� 5   
   -   5        $
 txtuf��5      $��UF��6   $
��Left=�6,   $��times new roman)�6G   $��620,179,0,0q�6d   $	��Top=�6y   $ -0.263,0&�6�   $��24��6�   $��25��6�   �� 5   
   -   5        $
 txttelefone��5      $��TELEFONE��6%   $
��Left=�68   $��times new roman)�6S   $��
65,215,0,0q�6p   $	��Top=�6�   $ -0.263,0&�6�   $��24��6�   $��71��6�   �� 5   
   -   5        $
 txtcel��5      $	��CEL��6    $
��Left=�6.   $��times new roman)�6I   $��370,215,0,0q�6f   $	��Top=�6{   $ -0.263,0&�6�   $��24��6�   $��33��6�   �� 5   
   -	   5        $
 txtemail��5      $��EMAIL��6"   $
��Left=�62   $��times new roman)�6M   $��
65,260,0,0q�6j   $	��Top=�6~   $ -0.263,0&�6�   $��24��6�   $��48��6�   �� 5   
   -
   5         ��Name$ tnome��5      $
��Left=�6!   
�������$��25��6O   $��
306,90,0,0q�6[    �� TextWrapping$
 Wrap=�6o   $	��Top=�6�   $	��480��6�   6�   �� 5   
   -   5        $
 txtrazaosocial��5      $��RAZAO SOCIAL��6(   $
��Left=�6?   $��times new roman)�6Z   $��
65,135,0,0q�6w   $	��Top=�6�   $ -0.263,0&�6�   $��24��6�   $��98��6�   �� 5   
   -   5        $ trazaosocial��5      $
��Left=�6(   
�������$��25��6V   $��171,133,0,0q�6b   $
 Wrap=�6w   $	��Top=�6�   $	��200��6�   6�   �� 5   
   -   5        $ 
tendereco1��5      $
��Left=�6&   
�������$��25��6T   $��516,135,0,0q�6`   $
 Wrap=�6u   $	��Top=�6�   $	��349��6�   6�   �� 5    
   -   5        $ tbairro1��5       $
��Left=�6$   
�������$��25��6R   $��130,175,0,0q�6^   $
 Wrap=�6s   $	��Top=�6�   $	��175��6�   6�   �� 5!   
   -   5        $ tmunicipio1��5!      $
��Left=�6'   
�������$��25��6U   $��435,177,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��165��6�   $ -0.4,-3.783&�6�   .��6�   z�5"      V� 5#      .~�5$      �� �� 5%      �� 5&       �� Angle$ -0.028Q�6&   T� 5'      5(      .��5)   '   5*      �� 5+   
   -   5        $ 
ttelefone1��5+      $
��Left=�6&   
�������$��23��6U   $��140,215,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��165��6�   $ 0.455,0&�6�   6�   �� 5,   
   -   5        $ tcel1��5,      $
��Left=�6!   
�������$��25��6O   $��430,215,0,0q�6[   $
 Wrap=�6p   $	��Top=�6�   $	��190��6�   6�   �� 5-   
   -   5        $ temail1��5-      $
��Left=�6#   
�������$��25��6Q   $��150,260,0,0q�6]   $
 Wrap=�6r   $	��Top=�6�   $	��475��6�   $ 0.5,0.5&�6�   .��6�   z�5.      V� 5/      .~�50      �� �� 51      �� 52      $ -0.056Q�6&   T� 53      54      .��55   '   56      &   System.Windows.Controls.DataGrid  57   
   -   5          Name$ Dtgridcliente��57         
IsReadOnly .    AutoGenerateColumns .  $
��Left=�6u   
�������$	��210��6�   $��
70,385,0,0q�6�   $	��Top=�6�   $	��815��6�   $ 0.5,0.5&�6�   ��. $��Visible=�63  $��Visible=�6h  ��6*   �� *Load+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$
  COD��6=      FontSize$ 20Q�6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *cod+6K     5:      $ NOME FANTASIA  ��6G   $ 20Q�6`    6%   �� *nome_fantasia+6`     5;      $ RAZAO SOCIAL��6F   $ 20Q�6\    6%   �� *razao_social+6\     5<      $ 	ENDEREÇO��6B   $ 20Q�6T    6%   �� *
endereco+6T     5=      $ BAIRRO��6@   $ 20Q�6P    6%   �� *bairro+6P     5>      $ 
MUNICÍPIO��6C   $ 20Q�6V    6%   �� *	municipio+6V     5?      $ UF��6<   $ 20Q�6H    6%   �� *uf+6H     5@      $ TELEFONE��6B   $ 20Q�6T    6%   �� *
telefone+6T     5A      $	 CEL��6=   $ 20Q�6J    6%   �� *cel+6J     5B      $ EMAIL��6?   $ 20Q�6N    6%   �� *email+6N   5H      �� 5I   
   $��LISTA DE REGISTROS��6   $��15(�6-   $��TIMES NEW ROMAN)�6;   
�������$
��Left=�6j   $��370,340,0,0q�6�   $	��Top=�6�   $ 0.658,1.346&�6�   $��27��6�   $	��160��6�   �� 5J   
   -   5        $��TIMES NEW ROMAN)�5J      $
��Left=�6.   $��1010,480,0,0q�6I   $	��Top=�6_   $	��160��6w   $��50��6�   
��� � �$ 
0.406,-0.6&�6�   �� 5K   
   $��	ATUALIZAR��6   $��TIMES NEW ROMAN)�6%   
�������$��15(�6U   $
��Left=�6c   $��1060,488,0,0q�6~   $	��Top=�6�   $ 0.526,1.154&�6�   
��� � �$
��Bold"�6�   $��27��6�   $��99��6  �� 5L   
   $��atualiza.png��6   $��1015,485,92,180q�6&   �� 5M   
   -   5        $
��Left=�5M      $��1010,410,0,0q�6-   $	��Top=�6C   $	��160��6[   $��50��6g   
���� ��6�   �� 5N   
   $��INSERIR��6   $��TIMES NEW ROMAN)�6"   
�������$��15(�6R   $
��Bold"�6`   $
��Left=�6r   $��1072,423,0,0q�6�   $	��Top=�6�   $ 0.526,1.154&�6�   $��27��6�   $��73��6�   �� 5O   
   $��iconInserir1.png��6   $��50��6*   $��1020,410,0,245q�65   $ 
0.21,0.444&�6M   $
��Left=�6p   �� 5P   
   -   5        $
��Left=�5P      $��1010,550,0,0q�6-   $	��Top=�6C   $	��160��6[   $��50��6g   
���  ��6�   �� 5Q   
   $��EXCLUIR��6   $��TIMES NEW ROMAN)�6"   
�������$
��Bold"�6S   $��15(�6e   $
��Left=�6s   $��1065,560,0,0q�6�   $	��Top=�6�   $ 0.526,1.154&�6�   
���  ��$��27��6�   $��79��6�   �� 5R   
   $��delete2.png��6   $��1026,560,108,110q�6%   �� 5S   
   $��CADASTRO DE CLIENTES��6   $��TIMES NEW ROMAN)�6/   $��20(�6L   
�������$
��Left=�6l   $��
334,20,0,0q�6�   $	��Top=�6�   $��33��6�   $	��249��6�   �� 5T   
   $��user1.2.png��6   $��950,35,2,510q�6%    J� Opacity$	 0.4Q�6;   �� 5U   
   $	��COD��6   $
��Left=�6   $��	65,90,0,0q�69   $	��Top=�6L   $ 0,0.808&�6d   $��26��6�   $��35��6�   �� 5V   
   -   5        $ tcod1��5V      $
��Left=�6!   $��23��6<   $��
115,92,0,0q�6H   $
 Wrap=�6\   
�������$	��Top=�6�   $��45��6�   6�   �� 5W   
   -   5        $��icone-voltar2.png��5W      $
��Left=�6+   $��46��6F   $��	24,16,0,0q�6R   $	��Top=�6e   $��78��6}   $ 0.462,0.217&�6�   6�   �� 5X   
   -   5         ��Name$ cbEstado��5X       �� Text$ 	Selecione��6%   
�������
�������$
��Left=�6[   $��15(�6v   $��Visible=�6�   $��664,170,0,0q�6�   $	��Top=�6�   $��76��6�   $��48��6�   6  �� 5Y   
   -   5        $
 thora��5Y      
����  �$��label��61   $
��Left=�6A   $��1094,664,0,0q�6\   $	��Top=�6r   $ 0.368,1.231&�6�   $��26��6�   $��81��6�   �� 5Z   
   -   5        $
 tdata��5Z      
����  �$
��lael��61   $��986,664,136,0q�6@   $	��Top=�6W   $��26��6o   5]      5^      