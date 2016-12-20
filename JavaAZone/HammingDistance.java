
package JavaAZone.Solutions.Easy;
/**
 * The Hamming distance between two integers is the number of positions at which
 * the corresponding bits are different. Given two integers x and y, calculate
 * the Hamming distance. Note: 0 ¡Ü x, y < 2^31.
 */
public class HammingDistance {

	public int hammingDistance(int x, int y) {
		// One line of solution with a built in method
		return Integer.bitCount(x, y);
	}

	public int hammingDistance2(int x, int y) {
		int xor = x ^ y, count = 0;
		for (int i = 0; i < 32; i++)
			count += (xor >> i) & 1;
		return count;
	}
}