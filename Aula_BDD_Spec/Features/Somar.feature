#Feature: Somar
#
#@mytag
#Scenario: Somar dois numeros
#	Given O primeiro numero é 50
#	And O segundo numero é 70
#	When Somados os dois numeros
#	Then O resultado deve ser 120
#
#	Scenario: Somar dois numeros -1
#	Given O primeiro numero é 50
#	And O segundo numero é 70
#	When Somados os dois numeros
#	Then O resultado deve ser 120
#
#	Scenario Outline: Somar dois numeroa - volume
#	Given O primeiro numero é <n1>
#	And O segundo numero é <n2>
#	When Somados os dois numeros
#	Then O resultado deve ser <r>
#
#	Examples: 
#		| n1 | n2 | r  |
#		| 0  | 0  | 0  |
#		| -1 | 10 | 9  |
#		| 6  | 9  | 15 |