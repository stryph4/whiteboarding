   M S B A M L   `   `   `  ����G  CWhiteBoading, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:WhiteBoading.StringsWhiteBoading.Strings  5   	   *    $WhiteBoading.Strings.SubstringAnswer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:WhiteBoading.Strings     5   	     � Title$  SubstringAnswer��5   	   $	��375��6!   $	��600��6.    � 
ResizeMode$ NoResize=�6:   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      $
��163* �6   �� 5      $
��131* �6   .+�5   
   �� -   5         ��Name$ Answer��5      $
��Left=�6$   $��
132,67,0,0q�6?   $
��Wrap=�6S   $	��Top=�6g   
�������$��2��6�   �� 6�   
���   �.�6�   �� $�        ��6�   6�   �� 6�   
����  �.�6�   �� $�public��6�   6	  �� 6  
���   �.�6(  �� $� ��6,  68  �� 6>  
����  �.�6V  �� $�string��6Z  6k  �� 6q  
���   �.�6�  �� $� Word(��6�  6�  �� 6�  
����  �.�6�  �� $�string��6�  6�  �� 6�  
���   �.�6�  �� $�
 sentence)��6�  6
  �� 6  �� 6  
���   �.�65  �� $�	        {��69  6M  �� 6S  �� 6_  
���   �.�6x  �� $6�0            sentence = sentence.Substring(0, 6);��6|  6�  �� 6�  �� 6�  
���   �.�6�  �� $�            ��6�  6�  �� 6  
����  �.�6  �� $�return��6  60  �� 66  
���   �.�6O  �� $�
 sentence;��6S  6h  �� 6n  �� 6z  
���   �.�6�  �� $�	        }��6�  6�  6�  �� 5   
   -   5         ��Name$ Close_Button��5      $��Close��6'   $��Center=�67   $��0,0,0,25q�6T   $��Bottom=�6f   $��75��6�   $��2��6�   6�   5      5      