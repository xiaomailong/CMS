   M S B A M L   `   `   `  ����   WpfApplication29    3WpfApplication2.MyControl.MyUserControl.ColorPicker   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -   $��colorPicker��.���   � RowDefinitions  �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � � ColumnDefinitions �� �� $
��Auto �.+��� -   $��	sliderRed��$��0�� � Minimum$ 0Q� � Maximum$	 255Q� � Value ��  �� ElementName$ colorPicker�� �� Path$	 Red��� -   $��sliderGreen��$��1��$ 0Q�$	 255Q� �� $ colorPicker��$ Green��� -   $��
sliderBlue��$��2��$ 0Q�$	 255Q� �� $ colorPicker��$
 Blue��� $��1��$��3��$��50��
���   �$��1������  �� Color �� $ colorPicker��$ Color��� -   $��	labelText��$��4������ $ colorPicker��$ ContentText�