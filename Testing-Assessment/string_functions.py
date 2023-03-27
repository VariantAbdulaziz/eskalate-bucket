def to_upper(string):
    result = []

    for char in string:
        if 97 <= ord(char) <= 122:
            result.append(chr(ord(char) - 32))
        else:
            result.append(char)

    return "".join(result)

def to_lower(string):
    result = []

    for char in string:
        if 65 <= ord(char) <= 90:
            result.append(chr(ord(char) - 32))
        else:
            result.append(char)
            
    return "".join(result)

def capitalize(string):
    result = ""

    if result:
        result += to_upper(string[0])
    result += to_lower(string[1:])

    return result