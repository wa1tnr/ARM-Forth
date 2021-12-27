\ 800f676
\ 2021-11-22 07:08:41

\ main.fs
target
turnkey
    decimal
    initGPIO

: test  ." this is going to be good 27 Dec 2021 at 13:29:55 UTC" ;

: kurtz cr 1 #, 2 #, 3 #, -99 #, -98 #, -97 #, .s ;

: togpin 13 #, ;

: said
  43 #, emit
  32 #, emit
  43 #, emit cr
;

turnkey decimal interpret
