;#DropDB DevexpressDemoEasyTest

#Application DevexpressDemo.Win
#Application DevexpressDemo.Web
#IfDef DevexpressDemo.Win

*Action About...
 
*Action OK

#EndIf

#IfDef DevexpressDemo.Web
!Action Navigation(My Details)
#EndIf
