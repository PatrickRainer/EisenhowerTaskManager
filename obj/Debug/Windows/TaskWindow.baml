   M S B A M L   `   `   `  ����P  LEisenhowerTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:EisenhowerTaskManager.WindowsEisenhowerTaskManager.Windows  5   	   .    (EisenhowerTaskManager.Windows.TaskWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   =local+clr-namespace:EisenhowerTaskManager.Windows     5   	     � Title$
  Task��5   	   $��356.144��6   $	��600��6'   
������� � 	Resources 5
       �� 
TargetType �� Property �� Value(  "System.Windows.Controls.DatePicker��%�  '��       '�� �     '       '�� �    �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 22��6*   �� 5       � ��$ 22q�6'   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 22��6*   5      �� 5   
   "  6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 22��6*   �� 5       � ��$
 Left=�64   �� 5       � ��$	 160��6&   5      �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$ 22��6*   �� 5       � ��$
 Left=�64   �� 5       � ��$	 160��6&   5      5       .��5!      � .+�5"   
   �� .+�5#      �� $��	Task Name��6   �� 5$      -   5         ��Name$ TaskNameTextBox��5$      �� 5%      $��Eisenhower Type��6   �� 5&      -   5         ��Name$ 
EmComboBox��5&      .@�5'      �� $��A��6   �� 5(      $��B��6   �� 5)      $��C��6   �� 5*      $��D��6   5+      �� 5,      $��Due Date��6     5-      -   5          Name$ DueDatePicker��5-      �� 5.      $��Status��6   �� 5/      -   5        $ StatusComboBox��5/      �� 50      $��Task Description��6   �� 51      -   5        $ DescriptionTextBox��51       �� TextWrapping$
 Wrap=�52      $��60��53      $��Stretch=�54      �� 55      	 �� Orientation$	 
Horizontal=�6   $��RightToLeft=�56      .+�57      �� -   5        
 ��Name$
 OkButton��57      $��OK��58      $��4q�59      5:      �� 5;      -   5        $
 FinishButton��5;      $��Ok, and Close Task��5<      $��4q�5=      5>      �� 5?      -   5        $
 CancelButton��5?      $��Cancel��5@      $��4q�5A      5B      5C      5D      5E      5F      