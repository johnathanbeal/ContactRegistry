   M S B A M L   `   `   `  ����a  ]AlternativeAssignment5_ContactRegistry, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:AlternativeAssignment5_ContactRegistry&AlternativeAssignment5_ContactRegistry  5   	   7    1AlternativeAssignment5_ContactRegistry.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:AlternativeAssignment5_ContactRegistry     5   	     � Title$  
MainWindow��5   	   $��616.368��6   $	��800��6-   .��5	      � -   5         �Name$ contactRegistryGrid��5	       � ColumnDefinitions 5
   
   �� 5      $	��36* �6   �� 5      $	��15* �6   �� 5      $	��15* �6   �� 5      $��5* �6   �� 5      $��3* �6   �� 5      �� 5      $	��18* �6   �� 5      $
��169* �6   �� 5      $
��533* �6   .+�5   
   �� -   5         ��Name$ 	addButton��5      $	��Add��6$   $
��Left=�62   $��
308,60,0,0q�6M   $	��Top=�6a   $	��100��6y   $��30��6�   $��8��6�   6�   �� 5   
   -   5        $ changeButton��5      $��Change��6'   $
��Left=�68   $��308,110,0,0q�6S   $	��Top=�6h   $	��100��6�   $��30��6�   $��8��6�   6�   �� 5   
   -   5        $ deleteButton��5      $��Delete��6'   $
��Left=�68   $��308,160,0,0q�6S   $	��Top=�6h   $	��100��6�   $��30��6�   $��8��6�   6�   �� 5   
   -   5         ��Name$ nameGroupBox��5      $
��Name��6)   $
��Left=�67   $	��100��6R   $��	30,20,0,0q�6_   $	��Top=�6r   $	��492��6�   $��9��6�   .��5      �� -   5         ��Name$ lastNameTextBox��5      $
��Left=�6/   $��23��6J   $��
147,47,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��319��6�   5      �� 5   
   -   5        $ addressGroupBox��5      $��Address��6,   $
��Left=�6=   $	��173��6X   $��
30,126,0,0q�6e   $	��Top=�6y   $	��492��6�   $��9��6�   .��5      �� -   5         ��Name$ countryComboBox��5       �� SelectedIndex$ 0��60   $
��Left=�6B   $��20��6]   $��147,117,0,0q�6i   $	��Top=�6~   $	��318��6�   6�   5      �� 5    
   -	   5        	 ��Name$	 streetLabel��5       $��Street��6%   $
��Left=�66   $��	0,172,0,0q�6Q   $	��Top=�6d   $��5��6|   $��2��6�   �� 5!   
   -
   5        $ cityTextBox��5!      $
��Left=�6'   $��23��6B   $��
89,200,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��320��6�   $��7��6�   $��2��6�   �� 5"   
   -   5        $	 	cityLabel��5"      $
��City��6#   $
��Left=�62   $��	0,203,0,0q�6M   $	��Top=�6`   $��5��6x   $��2��6�   �� 5#   
   -   5        $	 zipCodeLabel��5#      $��Zip Code��6&   $
��Left=�69   $��14.389,232,0,0q�6T   $	��Top=�6l   $��7��6�   $��1��6�   �� 5$   
   -   5        $ 
zipTextBox��5$      $
��Left=�6&   $��23��6A   $��
89,230,0,0q�6M   $
 Wrap=�6a   $	��Top=�6u   $	��320��6�   $��7��6�   $��2��6�   �� 5%   
   -   5        $ streetTextBox��5%      $
��Left=�6)   $��23��6D   $��
89,170,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��320��6�   $��7��6�   $��2��6�   �� 5&   
   -   5        $	 firstNameLabel��5&      $��
First Name��6(   $
��Left=�6=   $��3,42,0,0q�6X   $	��Top=�6j   $��6��6�   $��2��6�   �� 5'   
   -   5        $ firstNameTextBox��5'      $
��Left=�6,   $��23��6G   $��	89,42,0,0q�6S   $
 Wrap=�6f   $	��Top=�6z   $	��320��6�   $��7��6�   $��2��6�   �� 5(   
   -   5        $	 lastNameLabel��5(      $��	Last Name��6'   $
��Left=�6;   $��4,79,0,0q�6V   $	��Top=�6h   
 J� RenderTransformOrigin$
 -0.021,-0.138&�6�   $��6��6�   $��2��6�   �� 5)   
   -   5        $ 	 noOfRegisteredRecordsLabel��5)      $��No. Of Registered Records��64   $
��Left=�6X   $��281,260,0,0q�6s   $	��Top=�6�   ���	#FFEE2323$��8��6�   �� 5*   
   -   5        $ registeredCountTextBox��5*      $
��Left=�62   $��23��6M   $��447,263,0,0q�6Y   $
 Wrap=�6n   $��0��6�   $��50��6�   $	��Top=�6�   ���	#FFEE2323$��8��6�   �� 5+   
   -   5         ��Name$ listOfContacts��5+      $
��Left=�6*   $	��255��6E   $��
30,324,0,0q�6R   $	��Top=�6f   $	��729��6~   $��9��6�   57      �� 58   
   -   5        $	 contactNameLabel��58      $��Contact Name��6*   $��1��6A   $
��Left=�6Q   $��	3,304,0,0q�6l   $	��Top=�6   $��7��6�   �� 59   
   -   5        $	 addressLabel��59      $��Address Info��6&   $��8��6=   $
��Left=�6M   $��172,304,0,0q�6h   $	��Top=�6}   5:      5;      