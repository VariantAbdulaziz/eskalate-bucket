import unittest
from string_functions import *

class TestToUpper(unittest.TestCase):
    
    # Test the to_upper function with a lowercase string
    def test_from_lower(self):
        # Define the input and expected output values
        lower,  expected_from_lower = "lower", "LOWER"
        # Call the to_upper function with the input value
        actual = to_upper(lower)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_lower)

    # Test the to_upper function with an uppercase string
    def test_from_upper(self):
        # Define the input and expected output values
        upper, expected_from_upper = "UPPER", "UPPER"
        # Call the to_upper function with the input value
        actual = to_upper(upper)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_upper)

    # Test the to_upper function with a mixed-case string
    def test_from_mixed(self):
        # Define the input and expected output values
        mixed, expected_from_mixed = "MixED", "MIXED"
        # Call the to_upper function with the input value
        actual = to_upper(mixed)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_mixed)


class TestToLower(unittest.TestCase):

    # Test the to_lower function with a lowercase string
    def test_from_lower(self):
        # Define the input and expected output values
        lower,  expected_from_lower = "lower", "lower"
        # Call the to_lower function with the input value
        actual = to_lower(lower)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_lower)

    # Test the to_lower function with an uppercase string
    def test_from_upper(self):
        # Define the input and expected output values
        upper,  expected_from_upper = "UPPER", "upper"
        # Call the to_lower function with the input value
        actual = to_lower(upper)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_upper)

    # Test the to_lower function with a mixed-case string
    def test_from_mixed(self):
        # Define the input and expected output values
        mixed, expected_from_mixed = "MixED", "mixed"
        # Call the to_lower function with the input value
        actual = to_lower(mixed)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_mixed)


class TestCapitalize(unittest.TestCase):

    # Test the capitalize function with a lowercase string
    def test_from_lower(self):
        # Define the input and expected output values
        lower,  expected_from_lower = "lower", "Lower"
        # Call the capitalize function with the input value
        actual = capitalize(lower)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_lower)

    # Test the capitalize function with an uppercase string
    def test_from_upper(self):
        # Define the input and expected output values
        upper,  expected_from_upper = "UPPER", "Upper"
        # Call the capitalize function with the input value
        actual = capitalize(upper)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_upper)

    # Test the capitalize function with a mixed-case string
    def test_from_mixed(self):
        # Define the input and expected output values
        mixed,  expected_from_mixed = "MixED", "Mixed"
        # Call the capitalize function with the input value
        actual = capitalize(mixed)
        # Assert that the actual output matches the expected output
        self.assertEqual(actual, expected_from_mixed)


if __name__ == '__main__':
    unittest.main()
