"Every software module should have only reason to change" 

It is important to separate each responsability into separeted classes
because when the requirements change,that change will manifest through
a change in reponsability amongst the classes. If a class assumes more than
one responsability, then there will be more than one reason for it to change.

If a class has more than one responsability, then the responsabilities become coupled.
Changes to one responsability may impair or inhibt the ability of the class to meet the others.
This kinf of coupling leads to fragile designs that break in unexpected ways when changed.

