   M S B A M L   `   `   `  ����M  IproyectUniversidad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:proyectUniversidadproyectUniversidad  5   	   +    %proyectUniversidad.PanelAdministrador   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:proyectUniversidad     5   	     � Title$  Administrar Unla��5   	   $	��450��6"   $��918.5��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��100 �6   6+   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   � $��0��6   .+�5      �� $
��Left=�6   $��24��63   $��	10,10,0,0q�6?   $
��Wrap=�6R   $ ��Departamentos de la UNLA. ��6f   $	��Top=�6�   $	��235��6�   $��Century Gothic)�6�   $��16(�6�   �� 5      $
��Left=�6   $��31��63   $��	10,34,0,0q�6?   $
��Wrap=�6R   $7��1Seleccione un Departamento para ver sus carreras.��6f   $	��Top=�6�   $	��271��6�   $��Century Gothic)�6�   $��13(�6�   �� 5      -   5        $��comboBoxDptosAdmin��5      $��Century Gothic)�61   $��12(�6M   $
��Left=�6[   $��23��6v   $��	10,71,0,0q�6�   $	��Top=�6�   $	��271��6�   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� ��6(   �� *Nombre+5      5      5      5!      � 5#   
   -   5        $��gridCarrerasAdmin��5#   3   $��1��6   $y�Hidden=�6   .+�5$      �� $
��Left=�6   $��27��63   $��0,12,0,0q�6?   $
��Wrap=�6Q   $��Carreras del Dpto Elegido��6e   $	��Top=�6�   $	��208��6�   $��Century Gothic)�6�   $��16(�6�   �� 5%      $
��Left=�6   $��25��63   $��0,37,0,0q�6?   $
��Wrap=�6Q   $3��-Seleccione una carrera para ver sus materias.��6e   $	��Top=�6�   $	��294��6�   $��Century Gothic)�6�   $��13(�6�   �� 5&      -   5        $��comboBoxCarrerasAdmin��5&      $
��Left=�64   $��23��6O   $��4,70,0,0q�6[   $	��Top=�6m   $	��284��6�   $��Century Gothic)�6�   $��12(�6�   ��5'      �� 5(      .R�5)      �� $ 
Horizontal=�6%   .+�5*      �� ��6(   �� *Nombre+5+      5,      5.      5/      � 51   
   -   5        $ ��gridEleccionAlumnosMateria��51   3   $��2��6   $y�Hidden=�6   .+�52      �� $
��Left=�6   $��52��63   $��	10,10,0,0q�6?   $
��Wrap=�6R   $N��HElige si quiere ver los Alumnos Inscriptos o las materias de la carrera.��6f   $	��Top=�6�   $	��261��6�   $��Century Gothic)�6�   $��14(�6�   �� 53      -   5        $*��$comboBoxEleccionAlumnosMateriasAdmin��53   B   $��Century Gothic)�6   $��12(�64   $
��Left=�6n   $��23��6�   $��	10,70,0,0q�6�   $	��Top=�6�   $	��283��6�   .@�54      �� $��Alumnos��6   63   �� 55      $��Materias��6   64   56      57      � 58   
   -   5        $��
gridOpcion��58   ,   $��1��6   $��2��6    59      �� 5:      $��* �6    6-   �� 5;      $	��110 �6    6/   .+�5=      � -   5        $��gridEditorDatos��5=       $��0��6   $y�Hidden=�67   .+�5>      �� $��Nombre:��6   $
��Left=�6*   $��36��6E   $��	21,25,0,0q�6Q   $	��Top=�6d   $	��102��6|   $��Century Gothic)�6�   $��14(�6�   �� 5?      $��Donde estas agregando:��6   $
��Wrap=�6:   $
��Left=�6N   $��36��6i   $��	21,84,0,0q�6u   $	��Top=�6�   $	��102��6�   $��Century Gothic)�6�   $��14(�6�    J� RenderTransformOrigin$ 1.341,0.639&�6�   �� 5@      -   5        $��txtNombreAdmin��5@      $
��Left=�60   $��49��6K   $��
108,25,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��165��6�   $��Century Gothic)�6�   $��12(�6�   6�   �� 5B      -	   5        $��btnAdminAgregar��5B      $��Agregar��60   $
��Left=�6B   $��25��6]   $��
21,156,0,0q�6i   $	��Top=�6}   $��65��6�   $��Century Gothic)�6�   $ 	0.492,0.2&�6�   6�   �� 5C      -
   5        $��btnAdminEliminar��5C      $��Eliminar��61   $
��Left=�6D   $��25��6_   $��228,156,0,0q�6k   $	��Top=�6�   $��65��6�   $��Century Gothic)�6�   6�   �� 5D      -   5        $��btnAdminActualizar��5D      $��
Actualizar��63   $
��Left=�6H   $��25��6c   $��124,156,0,0q�6o   $	��Top=�6�   $��65��6�   $��Century Gothic)�6�   6�   �� 5E      -   5        $��txtDondeAgrego��5E      $��Center=�62   $��67��6O   $��
108,84,0,0q�6[   $
��Wrap=�6o   $	��Top=�6�   $��Century Gothic)�6�   $	��165��6�   5F      � 5G      -   5        $��gridOpcionesAlumno��5G       $��1��6   $y�Hidden=�6:   .+�5H      �� $
��Left=�6   $��62��67   $��	10,16,0,0q�6C   $
��Wrap=�6V   $B��<Haga click para Agregar un alumno a la carrera Seleccionada:��6j   $	��Top=�6�   $	��150��6�   $��Century Gothic)�6�   $��13(�6�   �� 5I      -   5        $��btnInscribirse��5I      {�.  $��Inscribir/Actualizar��6A   $
��Left=�6`   $��25��6{   $��
180,16,0,0q�6�   $	��Top=�6�   $	��103��6�   $��Century Gothic)�6�   $��11(�6�   �� 5J      -   5        $��btnSalir��5J      $��Salir��6)   $
��Left=�69   $��25��6T   $��
180,75,0,0q�6`   $	��Top=�6t   $��83��6�   $��Century Gothic)�6�   $ -2.012,5.16&�6�   �� 5K      -   5        $��btnEliminarAlumno��5K      {�.  $��Eliminar��6D   $
��Left=�6W   $��25��6r   $��
180,46,0,0q�6~   $	��Top=�6�   $	��103��6�   $��Century Gothic)�6�   6�   5L      5M      � 5O   
   $��1��6   $��2��6   .+�5Q      &   System.Windows.Controls.DataGrid  -   5        $��dataGridInfo��5Q         CanUserAddRows .  $��0,28,0,0q�6o   5S      �� 5T      -   5        $��btnMostrarAdmin��5T      $��M o s t r a r��6,   $
��Left=�6D   $��18��6_   $��	124,5,0,0q�6k   $	��Top=�6~   $	��312��6�   $��Century Gothic)�6�   5V      5X      5Z      