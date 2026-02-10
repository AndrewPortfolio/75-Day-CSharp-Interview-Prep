from collections import Counter

# s = "what the"
# print(s)
# s = s.replace(" ", "").upper()
# print(s)
# print(s.lower())

# def stringer(s,z):
#     print(f'Before a z replace + upper: {s}')
#     s = s.replace("a", "z").upper()
#     print(f'After a z: {s}')
#     print(f'Before " " --> "" + lower: {s}')
#     s = s.replace(" ", "").lower()
#     print(f'After " " --> "" + lower: {s}')
#     print(f'Before strip : {s}')
#     s = s.strip()
#     print(f'After strip : {s}')
#     combo = s.join(z)

#     print(combo)


# s = "   the sky is blue aaaaah    "
# z = "I HATE THE SUN JK"
# stringer(s,z)

# my_list = [1, 6, 5,3,4,2]
# my_list_str = ["Hey", "Hi", "What", "Do", "You", "Want"]

# my_list.append(7)
# print(my_list)
# my_list_str.append("No")
# print(my_list_str)
# my_list_str.extend(my_list)
# print(my_list_str)
# print(my_list)
# my_list.sort()
# print(my_list)
# my_list.reverse()
# print(my_list)
# my_list_str.reverse()
# print(my_list_str)

# the_dict = {"name": "Drew", "eth": "Asian", "DOB": "67-67-6767"}
# name = the_dict["name"] 
# print(name)

# the_dict["name"] = "Huge"
# print(the_dict["name"])


# the_dict.update({"name": "Drew"})
# print(the_dict["name"])

# for key, val in the_dict.items():
#     if key == "name":
#         print("Name is still a key")
#     else:
#         print("you're not ferd bro")

#     print(f'{key}: {val}')

# the_dict.pop("name")

# for k in the_dict:
#     print(f'What the helly: {k}')

# for key, val in the_dict.items():
#     print(f'{key}: {val}')

# print("GET TEST")
# val = the_dict.get("name", "Lover")
# print(val)
# print(the_dict.get("name", 0))
# print(Counter(the_dict))
# a = [1,1,1,1,2,4,5,6]
# print(Counter(a))

# def normalize(s: str) ->  str: 
#     print(s)
#     s = s.lower()
#     s = s.strip()
#     n = len(s)
#     result=[]
#     for i in range(n):
#         if not s.isalnum():      
#             result.append(s[i])
#         else: 
#             result.append("")
#     return "".join(result)

# s = "    What the Helly 123!!!!    "
# print(normalize(s))

def Word_Freq(s):
    s = s.lower()
    s = s.strip()

    word_dict = {}
    for i in range(len(s)):
        word =""
        count = 0
        for j in range(len(s), 0):
            if s[i] == s[j]:
                word = s[i]    
                count += 1 
        word_dict[s[i]] = count

    return word_dict


s = "What the helly bro what are you talking about stop acting like a chud"
print(Word_Freq(s))

def two_sum(arr, tar):
    for i in range(len(arr)):
        for j in range(1, len(arr)):
            if arr[i] + arr[j] == tar:
                ans = {arr[i]: i, arr[j]: j}
                return ans 
            
    return 0 

arr = [5,3,6,1,7,9,13,46,8]
tar = 10
print(two_sum(arr, tar))
            