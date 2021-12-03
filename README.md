# Simple Capsule.io Game
Nama : Zykha Aulia Putri

Kelas : 11 RPl 1

Absen : 

**Dokumentasi Game**

Capsule.io adalah game simpel yang berisikan capsule yang semakin banyak memakan makanannya, maka tubuhnya akan membesar dan membesar.

Fungsi script:

**Player Controller**

Script ini berisikan input untuk si capsule. Diawali dengan deklarasi variable GameObject, rigidbody, speed hingga x dan z input.
Di function Process input, kita akan mendapatkan input dari Input.GetAxis Horizontal maupun Vertical.
Untuk menggerakan capsulenya kita menggunakan rigidbody yang di addforce XYZ * speed.

Juga terdapat fungsi ScaleUp dimana jika capsule memakan makanannya, maka tubuh dari capsule akan bertambah besar sebesar 0.25 di x y maupun z.

**Score**

Didalam script ini, Kita akan menetapkan value pada text yang sudah kitabuat di canvas. Sebelumnya, kita harus menginclude UnityEngine.UI untuk mendapatkan UI dari game dan mendeklarasikan variable Text dan int ScoreValue.

Lalu di void update kita akan menetapkan value pada text berdasarkan ScoreValue.

**Money**

Di dalam script ini, kita akan menetapkan script ini pada prefab money yang sudah kita buat. di Prefab money ini berisikan sphere yang diberi warna kuning untuk menandakan bahwa sphere ini adalah money yang harus diambil oleh capsule (istilahnya makanannya capsule). 
Kita harus mengubah pada bagian sphere collider dan mengcheck bagian isTrigger. Lalu kita bisa memanggil function OnTriggerEnter dimana function ini akan berjalan ketika ada yang mengtrigger sphere (money) ini. 
Lalu kita mengset score Value pada Score script tadi dan menambahkannya sebesar 100 score.
Dan tidaklupa kita memperbesar character kita dan mengdestroy sphere ini.
