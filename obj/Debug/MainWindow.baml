   M S B A M L   `   `   `  ����P  LEisenhowerTaskManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:EisenhowerTaskManagerEisenhowerTaskManager  5   	   &     EisenhowerTaskManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:EisenhowerTaskManager     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � DataContext 5	   	   ��  �� RelativeSource �� *Self+.��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ APanel��5      $��0��5      $��0��6%   
���\\��.+�5      �� $��A - Import and Urgent��6   $
��Bold"�5      �� 5      $
��Auto=�6   .��5      �� -   5         ��Name$ ABoxListView��5      
���\\����5      �� *	EmTasks+ �� View 5      �� 5      ! �� ColumnHeaderContainerStyle 5      �� 5    "   	 �� 
TargetType"	 ��6(   .�5!   &   �� 
 �� Property
 � y� �� Value$ 	Collapsed=�6C   5"   #   .P�5$      ��  �� Width$	 300��6W    �� DisplayMemberBinding 6-   �� *
TaskName+6W   5%      5'      5(      5)      �� 5+   
   -   5        $ BPanel��5+      $��1��5,      $��0��6%   
��� ���.+�5.      �� $��B - Import not Urgent��6   $
��Bold"�5/      �� 50      $
��Auto=�6   .��51      �� -   5        $ BBoxListView��51      ��52      �� *BTasks+��53      ��  �� Path$ 
Background� �� ElementName$ BBoxListView�� 54      �� 55       56      �� 57   "   "	 ��6(   .�58   &   �� 
 � y�$ 	Collapsed=�6C   59   #   .P�5;      �� $	 300��6W    6-   �� *
TaskName+6W   5<      5>      5?      5D      �� 5F   
   -   5        $ CPanel��5F      $��0��5G      $��1��6%   
����p��.+�5I      �� $��C - Delegate��6   $
��Bold"�5J      �� 5K      $
��Auto=�6   .��5L      �� -   5        $ CBoxListView��5L      ��5M      �� *CTasks+��5N      �� $ 
Background�$ CBoxListView�� 5O      �� 5P       5Q      �� 5R   "   "	 ��6(   .�5S   &   �� 
 � y�$ 	Collapsed=�6C   5T   #   .P�5V      �� $	 300��6W    6-   �� *
TaskName+6W   5W      5Y      5Z      5[      �� 5]   
   -   5        $ DPanel��5]      $��1��5^      $��1��6%   
��� �|�.+�5`      �� $��
D - Delete��6   $
��Bold"�5a      �� 5b      $
��Auto=�6   .��5c      �� -   5        $ DBoxListView��5c      ��5d      �� *DTasks+��5e      �� $ 
Background�$ DBoxListView�� 5f      �� 5g       5h      �� 5i   "   "	 ��6(   .�5j   &   �� 
 � y�$ 	Collapsed=�6C   5k   #   .P�5m      �� $	 300��6W    6-   �� *
TaskName+6W   5n      5p      5q      5u      5v      5w      