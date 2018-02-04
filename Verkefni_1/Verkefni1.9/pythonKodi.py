#ég gerði kóðann af þessu verkenfi í python af því ég kann ekki það vel á
#lista í c++ þannig það væri bara mikklu léttara að gera þetta í python


A = []
B = []
C = []
numberOfDisks = 64

for x in range(numberOfDisks, 0, -1):
    A.append(x)

def move(a, start, mid, end):
  if a > 0:
      move(a -1, start, end, mid)
      mid.append(start.pop())

      print("A = ", A, "\nB = ", B, "\nC = ", C, "\n------------------------------------------------------------------")

      move(a-1, end, mid, start)

move(numberOfDisks, A, B, C)
