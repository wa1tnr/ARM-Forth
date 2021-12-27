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

: wiggle blink blink blink blink blink
  blink blink blink blink blink
  blink blink blink blink blink
;

: olit 1 #, dup drop 2 #, dup drop 3 #, dup drop ;

turnkey decimal interpret
