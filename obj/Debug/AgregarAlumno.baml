   M S B A M L   `   `   `  ����M  IproyectUniversidad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:proyectUniversidadproyectUniversidad  5   	   &     proyectUniversidad.AgregarAlumno   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:proyectUniversidad     5   	     � Title$  AgregarAlumno��5   	   $��462.17��6   $��408.925��6/   .��5	      � -   5        .+�5
   
   �� $
��Left=�6   $��31��6/   $��	71,27,0,0q�6;   $
��Wrap=�6N   $"��          Ingrese los datos:��6b   $	��Top=�6�   $	��271��6�   $��Century Gothic)�6�   $��20(�6�   $
��Bold"�6�   �� 5   
   $��	Nombre/s:��6   $
��Left=�6$   $��27��6?   $��	25,87,0,0q�6K   $	��Top=�6^   $	��106��6v   $��Century Gothic)�6�   $��16(�6�   �� 5   
   $��Apellido/s:��6   $
��Left=�6&   $��27��6A   $��
25,139,0,0q�6M   $	��Top=�6a   $	��106��6y   $��Century Gothic)�6�   $��16(�6�   �� 5   
   $
��DNI:��6   $
��Left=�6   $��27��6:   $��
25,184,0,0q�6F   $	��Top=�6Z   $	��106��6r   $��Century Gothic)�6~   $��16(�6�   �� 5   
   $��Fecha de nacimiento:��6   $
��Left=�6/   $��22��6J   $��
25,282,0,0q�6V   $	��Top=�6j   $	��141��6�   $��Century Gothic)�6�   $��12(�6�   �� 5   
   $��Genero:��6   $
��Left=�6"   $��27��6=   $��
25,232,0,0q�6I   $	��Top=�6]   $	��106��6u   $��Century Gothic)�6�   $��16(�6�   �� 5   
   -   5        $��comboBoxGenero��5      $��Century Gothic)�6)   $��14(�6E   $��152,232,59,164q�6S   .@�5      �� $��Femenino��6   $��Century Gothic)�6.   $��14(�6J   �� 5      $��	Masculino��6   $��Century Gothic)�6/   $��14(�6K   �� 5      $
��Otro��6   $��Century Gothic)�6*   $��14(�6F   5      (  "System.Windows.Controls.DatePicker  5   
   -   5        $��fechaNacimientoCalendario��5      $
��Left=�66   $��60��6Q   $��171,282,0,0q�6]   $	��Top=�6r   $	��171��6�      DisplayDateStart$ 
01/01/1930X�6�      DisplayDateEnd$ 
12/31/2003X�6�   �� 5   
   -   5        $��btnAgregarAlumno��5      $��Agregar��6)   $
��Left=�6;   $��27��6V   $��
54,366,0,0q�6b   $	��Top=�6v   $	��135��6�   $��Century Gothic)�6�   $��15(�6�   6�   �� 5   
   -   5        $��btnCancelarAlumno��5      $��Cancelar��6*   $
��Left=�6=   $��27��6X   $��223,366,0,0q�6d   $	��Top=�6y   $	��119��6�   $��Century Gothic)�6�   $��15(�6�   6�   �� 5   
   -   5        $��txtNombreAlumno��5      $
��Left=�6)   $��27��6D   $��
152,87,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $	��Top=�6x   $	��190��6�   $��Century Gothic)�6�   $��15(�6�   �� 5   
   -   5        $��txtApellidoAlumno��5      $
��Left=�6+   $��27��6F   $��152,139,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��190��6�   $��Century Gothic)�6�   $��15(�6�   �� 5   
   -   5        $��txtDniAlumno��5      $
��Left=�6&   $��27��6A   $��152,184,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��190��6�   $��Century Gothic)�6�   $��15(�6�   5      5      