import datetime
class Calculator:
   def add(self, argA, argB):
      return argA + argB
   def sub(self, argA, argB):
      return argA - argB
   def PrintTest(self): print("Hello from a Python function") 
   def CurrentDateTime(self):
       x = datetime.datetime.now()
       print(x)