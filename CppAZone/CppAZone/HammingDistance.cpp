#pragma once

namespace CppAZone{
	namespace Solutions {
		namespace Easy {

			class HammingDistance {
			public:
				int hammingDistance(int x, int y) {
					// One line solution with a built in function of GCC
					// return __builtin_popcount(x^y);
				}

				// Bit Manipulation
				int hammingDistance2(int x, int y) {
					if (x == y) return 0;
					int count = 0;
					while (x || y) {
						if ((x & 1) != (y & 1)) count++;
						x = x >> 1;
						y = y >> 1;
					}
					return count;
				}
			};
		}
	}
}