x=2
y=1
x=x+y
if(x==1):
    x=x+y
    y=y+1
    print(f"esse é o primeiro{x}, {y}")
elif (y==1):
    x=x-y
    y=y*2
    print(f"esse é o segundo {x}, {y}")
else:
    x=x+1 
    y=5
    print(f"esse é o terceiro{x}, {y}")
