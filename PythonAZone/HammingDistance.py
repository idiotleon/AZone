

class HammingDistance(object):
    def hammingDistance(self, x, y):
        """
        :param x: int
        :param y: int
        :return: int
        """
        x = x^y
        y = 0
        while x:
            y += 1
            x = x & (x - 1)
        return y
