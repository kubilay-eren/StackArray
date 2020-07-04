# StackArray

Dizideki 3 yığının verimli bir şekilde çalışabilmesi isin 2 ekstra dizi kullanıldı.

İki ekstra dizi kullanılır:
1) top[]: Bu k boyutundadır ve üst yığınların dizinlerini tüm yığınlarda depolar.
2) next[]: Bu, n boyutundadır ve arr dizisindeki öğeler için sonraki öğenin dizinlerini depolar. Burada arr, k yığınlarını depolayan gerçek dizidir.
K yığınları ile birlikte, arr içindeki bir serbest yuva yığını da korunur. Bu yığının üst kısmı 'ücretsiz' değişkeninde saklanır.
Üstündeki tüm girişler, tüm yığınların boş olduğunu göstermek için -1 olarak başlatılır. next[i] 'deki tüm girişler i + 1 olarak başlatılır, 
çünkü tüm yuvalar başlangıçta boştur ve bir sonraki yuvaya işaret eder. Serbest yığının en üstünde, 'free' 0 olarak başlatılır.
