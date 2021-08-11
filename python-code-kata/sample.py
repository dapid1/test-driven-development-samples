from numpy import NaN
import pandas as pd
import math
import unittest

df = pd.read_csv('Groceries_dataset.csv')
arr = df.to_numpy()

occurences = {}
supermarket = {}
specials = {}

for row in arr:

    if row[2] in occurences:
        occurences[row[2]] += 1
        if row[2] not in supermarket:
            supermarket[row[2]] = row[3]
    else:
        occurences[row[2]] = 1    

unit_prices = []

for i in arr:
    unit_prices.append(i[3])

########## Unit Testing ############

def checkIfNumerical(x):       
    try:
        int(x)
        return True
    except:
        return False

def checkForNumericalValues(arr):

    for val in arr:
        if not checkIfNumerical(val):
            return False

    return True    

def checkForNullValues(arr):

    for i in arr:
        if math.isnan(i):
            return True

    return False  

def checkForFreeItems(arr):

    for i in arr:
        if i <= 0:
            return True

    return False   
 
def checkingTwoOccurencesSpecial(occurences):

    for k, v in occurences.items():
        if v == 2:
            return True

    return False        

def checkingThreeOccurencesSpecial(occurences):

    for k, v in occurences.items():
        if v == 3:
            return True

    return False

def checkingOneOccurence(occurences):

    for k, v in occurences.items():
        if v == 1:
            return True

    return False   


class TestNotebook(unittest.TestCase):
    
    def test_single_value(self):
        self.assertEqual(checkIfNumerical(2.5), True)

    def test_numerical_values(self):
        self.assertEqual(checkForNumericalValues([-2.3, 0, 5850]), True)

    def test_null_values(self):
        self.assertTrue(checkForNullValues([2.5, 2, NaN, 66]))

    def test_free_items(self):
        self.assertTrue(checkForFreeItems([-2.5, 0, -3.5, 0])) 

    def test_two_occurences(self):
        self.assertEqual(checkingTwoOccurencesSpecial({"beans" : 1, "bread" : 3, "milk" : 2, "cheese" : 1}), True)      

    def test_three_occurences(self):
        self.assertEqual(checkingThreeOccurencesSpecial({"beans" : 1, "bread" : 3, "milk" : 2, "cheese" : 1}), True) 

    def test_one_occurences(self):
        self.assertEqual(checkingOneOccurence({"beans" : 1, "bread" : 3, "milk" : 2, "cheese" : 1}), True)

unittest.main(argv=[''], verbosity=2, exit=False)