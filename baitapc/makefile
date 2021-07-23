main: main.o libmymath.a
	gcc -o main main.o libmymath.a
main.o: main.c
	gcc -c main.c
libmymath.a: giaithua.o tongchan.o tongle.o somu.o 
	ar crv libmymath.a giaithua.o tongchan.o tongle.o somu.o
giaithua.o: giaithua.c
	gcc -c giaithua.c
tongchan.o: tongchan.c
	gcc -c tongchan.c
tongle.o: tongle.c
	gcc -c tongle.c
somu.o: somu.c
	gcc -c somu.c
