   M S B A M L   `   `   `  ����K  GContentFilterApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ContentFilterAppContentFilterApp  5   	   $    ContentFilterApp.Authorization   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:ContentFilterApp     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Authorization��5	   	   $	��470��6   $	��380��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N    � WindowStyle$
 None=�6s    � AllowsTransparency . 
������ ��6�   Z�  � Triggers 5      :� 5   
    :� RoutedEvent$ Loaded��6   [�5      �� 5      .��5      �� .��5      W�  �� TargetProperty$ Opacity�5   !    W� From$	 0.4X�5   !   		 W� To$	 1X�5   !   
 g� Duration$
 0:0:1D�5   !   5      5      5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5       .+�5#      ��  �� CornerRadius$ 20��6   $��2��6'   $��1q�68   ��5$      �� 5%       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5&      �  � Color$ 	#FF94F7CE��6'    � Offset$ 0Q�69   � 5'      $ 	#FF58F02B��6'   $ 1Q�69   5(      ��5*      �� 5+      $ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;   $ 0.5,0&�6_   .��5,      � $ 	#FF76F370��6'   $ 1Q�69   � 5-      $ 	#FF0E41F0��6'   5.      50      �� 52      $��Center=�6   .+�53      �� $��images/Logo1.png��6   $	��120��62   �� 54      $��SENTENCE��6   $��Light"�55      $��	helvetica)�56      $��24(�57      $��Center=�58      ��59      �� 5:      $ 0.5,1&�6.   $ 0.5,0&�6?   .��5;      � $ 	#FF94F7CE��6+   $ 0Q�6=   � 5<      $ 	#FF58F02B��6+   $ 1Q�6=   5=      5?      5@      �� 5B      $��1��6   .+�5C      ��  �� Orientation$ 
Horizontal=�6   .+�5D      �� -   5         ��Name$ textbox_login��5D      $��Light"�5E      $��20(�5F      $��
Логин��5G      $��Center=�5H      
������ $��0q�5J      $	��224��5K      $
��Left=�5L      
�������$��36��5N      $��60,0,0,0q�5O      6,   '  !MaterialDesignThemes.Wpf.PackIcon  5P         Kind$
 User=�6.   $��25��6:   $��10q�6E   $��25��6Q   $��Center=�6]   ���	#DDFFFFFF$��Center=�6�    J� RenderTransformOrigin$ -0.907,0.52&�6�   5R      �� 5S      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5T      G� -   5         G�Name$ textbox_password��5T   "   $��Light"�5U      $��20(�5V       G� Password$ Пароль��5W      $��Center=�5X      
������ $��0q�5Z      $	��223��5[      $
��Left=�5\      
�������$��36��5^      $��60,0,0,0q�5_      6+     5`      $
 Lock=�6.   $��25��6:   $��10q�6E   $��25��6Q   $��Center=�6]   ���	#DDFFFFFF$��Center=�6�   $ -0.907,0.52&�6�   5b      �� 5c      $ 
Horizontal=�6   $��0,40,0,0q�66   .+�5d      �� -   5        $	��100��5d      $��40��6)   $��
ВЫЙТИ��65   $��Segoe UI Semibold)�6E   $��	60,0,60,0q�6d   $��14(�6w      
ButtonGrad#��[  6�   $��Normal"�6�   �� 5e      -   5        $	��100��5e      $��40��6)   $��
ВОЙТИ��65   $��Segoe UI Semibold)�6E   $��14(�6d   #��[  6r   6�   5f      5g      �� 5h      $��2��5i      
������� J� Opacity$	 0.5Q�5k      $��64,37,64,186q�6#   $��1��69   �� 5l      $��2��5m      
�������$	 0.5Q�5o      $��64,102,64,121q�6   $��1��66   5s      5t      5u      