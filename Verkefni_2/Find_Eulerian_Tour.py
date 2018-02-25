def getEnd(graph, num):
  counter = 0
  for i in range(len(graph)):
    if graph[i][0] == num or graph[i][1] == num:
      counter += 1
  return counter

def find_eulerian_tour(graph, array, endin, endoften):
  left = graph[0][0]
  right = graph[0][1]
  lastnum = array[-1]

  if len(array) == len(graph):
    array.append(endin)
    return array

  elif lastnum == left:
    if left == endin and endoften > 1:
      array.append(right)
      graph.append(graph[0])
      endoften = endoften -1
      del graph[0]
      return find_eulerian_tour(graph, array, endin, endoften)
    elif left != endin:
      array.append(right)
      graph.append(graph[0])
      del graph[0]
      return find_eulerian_tour(graph, array, endin, endoften)
    else:
      graph.append(graph[0])
      del graph[0]
      return find_eulerian_tour(graph, array, endin, endoften)


  elif lastnum == right:
    if right == endin and endoften > 1:
      array.append(left)
      graph.append(graph[0])
      endoften = endoften - 1
      del graph[0]
      return find_eulerian_tour(graph, array, endin, endoften)
    elif right != endin:
      array.append(left)
      graph.append(graph[0])
      del graph[0]
      return find_eulerian_tour(graph, array, endin, endoften)
    else:
      graph.append(graph[0])
      del graph[0]
      return find_eulerian_tour(graph, array, endin, endoften)

  else:

    graph.append(graph[0])
    del graph[0]


    return find_eulerian_tour(graph, array, endin, endoften)







graf =   [(1, 13), (1, 6), (6, 11), (3, 13),
(8, 13), (0, 6), (8, 9),(5, 9), (2, 6), (6, 10), (7, 9),
(1, 12), (4, 12), (5, 14), (0, 1), (2, 3), (4, 11), (6, 9),
(7, 14), (10, 13)]

dummy = [graf[0][0], graf[0][1]]

graf.reverse()

often = getEnd(graf, dummy[0])

print(find_eulerian_tour(graf, dummy, dummy[0],often ))
