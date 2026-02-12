import string
from collections import Counter

# PRACTICE 

# def normalize(s):
#     s = s.strip()
#     s = s.lower()
#     # s = s.replace(",", "")
#     s = "".join(c for c in s if c.isalnum() or c.isspace())
    
#     return s

# def arrayify(s):
#     result = []
#     for i in range(len(s)):
#         if s[i].isalnum():
#             result.append(s[i])
    
#     return result

# def dictify(arr):
#     d = {}
#     for val in arr:
#         if val in d:
#             d[val] += 1
#         else:
#             d[val] = 1
    
#     return d

#END PRACTICE

def word_freq(s):
    s = s.lower()
    s = s.strip()
    s = "".join(c for c in s if c.isalnum() or c.isspace())
    words = s.split()

    d = {}
    for word in words:
        d[word] = d.get(word, 0) + 1

    return d 

if __name__ == "__main__":

#PRACTICE
    # s = "Hello, World!!!!"
    # print(s)
    # print(normalize(s))

    # s = "a,b,c,d,,,e"
    # print(f'Before arrayify: {s}')
    # arr = arrayify(s)
    # print(f'After {arr}')

    
    # arr.append("a")
    # arr.append("a")
    # arr.append("a")
    # arr.append("b")
    # arr.append("b")
    # arr.append("c")
    # arr.append("e")

    # print(f'Before dictify: {arr}')
    # d = dictify(arr)
    # print(f'After dictify: {d}')
    # print(f'Dict Get: {d.get("c", 0)}')
    # print(f'Counter Ver: {Counter(arr)}')
#END PRACTICE

    s1 = "a a a"
    print(f'S1: {word_freq(s1)}')
    s2 = "A a"
    print(f'S2: {word_freq(s2)}')
    s3 = "hi, hi!!"
    print(f'S3: {word_freq(s3)}')
    s4 = ""
    print(f'S4: {word_freq(s4)}')
    
    
