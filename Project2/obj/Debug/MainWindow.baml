   M S B A M L   `   `   `  ����C  ?Project2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Project2Project2  5   	   9!clr-namespace:Project2.ViewModelsProject2.ViewModels  5   	       Project2.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Project2     5   	   4models!clr-namespace:Project2.ViewModels     5   	   $��600.4��5      $��810.8��6)   ���	#FFE5DFDF  � WindowStartupLocation$  CenterScreen=�6N    � 
ResizeMode$ NoResize=�6s    � 	Resources 5
       �� DataType&   Project2.ViewModels.FiliereModel   Project2.GestionFiliere � DataContext'  !Project2.ViewModels.EtudiantModel   Project2.Gestionetudiant'  !Project2.ViewModels.StatiqueModel   Project2.Statique��%I  (��       5   0   *, +)(�� T     5   1   *, +)(�� �     5   1   *, +)�� 5   
   FiliereTemplate��"  60   .R�5         6#   �� 5      �� 5   
   EtudiantTemplate��"  61   .R�5         6$   �� 5      �� 5   
   StatiqueTemplate��"  61   .R�5         6   �� 5      5      .��5      � -   5         �Name$
 Home��5      $
��Left=�6   $��593.1��64   $��1.8,3.6,0,0q�6C   $	��Top=�6X   $��807.6��6p    � ColumnDefinitions 5   
   �� 5      �� 5      $
��592* �6   .+�5   
   �� $
��Left=�6   $��56��6/   $��65.6,47.929,0,0q�6;   ���	#FF6C1C1C$	��Top=�6g   $��683.2��6    �� RadiusX$ 5��6�    �� RadiusY$ 10��6�   $��1��6�   	 J� OpacityMask	 �	#FFCA7C7C���	#FFF7F7FA6�   �� 5   
   -   5        $��Gestion des étudiants��5      $
��Left=�61   $
��30.4��6L   $��95.6,61.529,0,0q�6Z   $	��Top=�6s   $��190.4��6�   
�������$��Snap ITC)�6�   $��14(�6�   $��1��6�   ��5       
� 5!      .��5"      � 
 � Color$
 Black��6#   � 5#      $
 	#FF2C90FD��6#    � Offset$ 1Q�65   5$      5&      �� 5'   
   -   5        $��Gestion de Filiere ��5'      $
��Left=�6/   $
��30.4��6J   $��336.8,60.329,0,0q�6X   $	��Top=�6r   $	��176��6�   
�������$��Snap ITC)�6�   $��14(�6�   $��1��6�   ��5(      �� 5)       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5*      � $
 Black��6#   $ 1Q�61   � 5+      $
 	#FF2C90FD��6#   5,      5.      �� 5/   
   -   5        $��Statique��5/      $
��Left=�6$   $
��30.4��6?   $��570.4,59.129,0,0q�6M   $	��Top=�6g   $��150.4��6   
�������$��Snap ITC)�6�   $��14(�6�   $��1��6�   ��50      
� 51      .��52      � $
 Black��6#   $ 0Q�61   � 53      $
 	#FF2C90FD��6#   $ 0.941Q�65   54      56      � 57   
   $��1��6   $
��Left=�6   $��392.1��6:   $��3.738,129.9,0,0q�6I   $	��Top=�6b   $��800.4��6z   .+�58        6&   �� 59      ��6   �� 5;      5<      5=      