   M S B A M L   `   `   `  ����K  GSales Management, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Sales_Management.ViewSales_Management.View  5   	   *    $Sales_Management.View.AddProductView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Sales_Management.View     5   	     � Title$  Add Product��5   	    � 
ResizeMode$ NoResize=�6   $	��250��63   $	��300��6@   .��5
      �  � RowDefinitions 5   
   �� 5      �� 5      $��2* �6   �� 5      .+�5   
   � $��0��6   .+�5      �� $��Center=�65   $��Center=�6R   $	��200��6m   
���   �$��1q�6�   ��6   �� *ProductData+6�   5      � 5   
   $��1��6    � ColumnDefinitions 5      �� 5      $	��43* �6#   �� 5      $	��18* �6#   �� 5      $	��67* �6#   �� 5      $	��43* �6#   �� 5      $
��129* �6#    5       �� 5!      �� 5"      .+�5%      �� $��1��6:   $��-��6G   $��Center=�6S   $��Center=�6p   ��6   �� *DecrementCommand+6p   �� 5&      $��1��6:   $��3��6G   $��+��6W   $��Center=�6c   $��Center=�6�   ��6   �� *IncrementCommand+6�   �� 5'      $��1��6   $��1��6#   $��Center=�6r    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $��61��6�   $��2��6�   ��63   �� *
Quantity+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5(      $��3��6   $��Maximum Allowed:��6$   $
��Left=�6?   $��Center=�6Z   $��2��6u   $��42,0,0,0q�6�   �� 5)      $��3��6   $��	Quantity:��6*   $
��Left=�6>   $��Center=�6Z   �� 5*      $��1��6   $��4��6!   $��Center=�6P   $��Center=�6k   $��1q�6�   
���   �$��30��6�   $��30��6�   ��61   �� *
MaxAllowed+6�   5+      � 5,   
   $��3��6    5-      �� 5.      $��2* �6#   �� 5/      �� 50      .+�53      �� $��1��68   $��Confirm��6H   $��25��6Z   $��60��6f   ��6   �� *ConfirmCommand+6f   �� 54      $��2��67   $��Cancel��6G   $��25��6X   $��Center=�6d   $��Center=�6�   ��6   �� *CancelCommand+6�   55      57       J� InputBindings 59      �� 5:   
   
 �� Key$ Subtract��6    �� Command 6$   �� *DecrementaCommand+�� 5;   
   $	 Add��6    6   �� *IncrementCommand+�� 5<   
   $ Enter��6    6!   �� *ConfirmCommand+5>      