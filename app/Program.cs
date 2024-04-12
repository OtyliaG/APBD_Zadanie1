public static int MaxValue(int[] numbers) {
    if (numbers == null || numbers.Length == 0)
        throw new ArgumentException("Array cannot be null or empty.");

    int max = numbers[0];
    for (int inna_zmienna_v2 = 1; inna_zmienna_v2 < numbers.Length; inna_zmienna_v2++) {
        if (numbers[inna_zmienna_v2] > max)
            max = numbers[inna_zmienna_v2];
    }
    return max;
}