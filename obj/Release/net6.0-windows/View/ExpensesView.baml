   M S B A M L   `   `   `  ���� K  GSales Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Sales_Management.ViewSales_Management.View  (    "Sales_Management.View.ExpensesView   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:Sales_Management.View     .��� ���	#FFC9ECFC  � ColumnDefinitions  �� �� ��  � RowDefinitions �� $��7* ��� $	��43* ��� $	��10* �.+�� ���#888d94$��2��$��1��$��0,0,0,20q�$��2�� �� �� $��2* �.+�� 
�������$��0��$��4,4,4,1q�  �� �� $��2* � �� $��2* ��� $��2* �.+�� $��2��$��2��  �� $
��151* ��� $
��141* ��� $��40��$��
Received :��$��18(�$
��Bold"��� $��40��$��Change:��$��1��$��18(�$
��Bold"�$��5,3,3,3q��� -   $��10,22,10,22q�$��0��$��20(�$��1������ *
Received+ �� UpdateSourceTrigger$ PropertyChanged=��� -   $��10,22,10,22q�$��1��$��1�� �� 
IsReadOnly$
 True��$��20(����� *Change+$ PropertyChanged=�� 
�������$��1��$��4,1,4,4q�  �� �� ��  �� �� �� �� �� .+���  
  Others#��[  $��1��$��0��$��0������ *DisplayNumberCommand+����  �� RelativeSource ��  �� Mode$
 Self=� �� Path$ Content��� #��[  $��2��$��0��$��1������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��3��$��0��$��2������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��4��$��1��$��0������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��5��$��1��$��1������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��6��$��1��$��2������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��7��$��2��$��0������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��8��$��2��$��1������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��9��$��2��$��2������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��0��$��3��$��0������ *DisplayNumberCommand+����  �� $
 Self=�$ Content��� #��[  $��.��$��3��$��2������ *DisplayNumberCommand+����  �� $
 Self=�$ Content���   Rounded#��[ $��Close��$��3��$��1�����#bf2832���� *CloseCommand+�� #��[ $��4��$��1��$��OK��
��� � ����� *	OKCommand+�� #��[ $��4��$��2�����#bf2832$��Remove������ *RemoveCommand+� 
�������$��1��$��2��$��2�� �� $	��50* ��� $
��374* ��� $	��71* ��� $	��35* �.+�� $��2��  �� �� �� �� �� �� .+��� #��[ $��4�����  �� �� .+��� $��
Clear Sale���� $��1��$��Cancel Sale���� #��[ $��Save and Print��$��5��&   System.Windows.Controls.DataGrid  -     Name$ datagrid��   
IsReadOnly$
 True��	   AutoGenerateColumns$	 False��$��1��$��2,2,0,2q����	#FF5C6167���	#FFCBCBCB���� *Cart+
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Id+  $ 	Item Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200    	FontStyle$ Normal$�   CanUserResize$ False�� �� *Name+  $ 
Unit Price��$	 200  �� *Price+  $ Quantity��$	 200  �� *
Quantity+  $ Total Price��$	 200 $
 True�� �� *
TotalPrice+� $��0��  �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� $��
Product ID��$��0���� $��Card ID��$��3���� $��1������ *	ProductId+$ PropertyChanged=��� $��4������ *CardId+$ PropertyChanged=��� #��[ $��Search��$��5��$��10q��� #��[ $��Search��$��2��$��10q����� *SearchProduct+� ���	#FFC9ECFC$��3��� $��0��$��2��  �� $��2* ��� $��5* �.+��� $��Total :��$��0��$��0��$��Center=�$��Center=�$��18(�$
��Bold"��� -   $
 True��$��20(�$��80��$��1��
�������$��
2,22,20,22q����� *Total+$ PropertyChanged=�� $��0��$��2��.+��� $��Center=�$��Center=�$��Sale Receipt��$��22(�$
��Bold"�