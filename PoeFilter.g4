grammar PoeFilter;

COMMENT: '#'.+?[\n] -> skip;
WS:    [ \t\r\n]+ -> skip ;
DIGITS: [0-9]+;
COMPAREOP: '='| '!='|'<'|'>'|'<='|'>=';
RARITY: 'Normal'| 'Magic'| 'Rare' | 'Unique';
SHOW: 'Show';
HIDE: 'Hide';
SOCKET: [RGBW]+ ;
QUOTESOCKET:'"' SOCKET '"';
STR: .+? | ~[\r\n "]+;
QUOTESTR:'"' STR '"';

strValue: QUOTESTR | STR;
socketValue: QUOTESOCKET | SOCKET;
compareOpNullable:COMPAREOP?;
visibility: SHOW | HIDE;
params:strValue (strValue)*;
red:DIGITS;
green:DIGITS;
blue:DIGITS;
alpha:DIGITS?;
color: red green blue alpha;
poeClass: 'Class' params;
poeBaseType: 'BaseType' params;
poeFontSize: 'SetFontSize' DIGITS;
poeTextColor: 'SetTextColor' color;
poeBackgroundColor: 'SetBackgroundColor' color;
poeBorderColor: 'SetBorderColor' color;
poeAlertSound: 'PlayAlertSound' DIGITS DIGITS;
poeRarity: 'Rarity' compareOpNullable RARITY;
poeSocketGroup: 'SocketGroup' socketValue;
poeLinkedSockets: 'LinkedSockets' compareOpNullable DIGITS;
poeSockets: 'Sockets' compareOpNullable DIGITS;
poeItemLevel: 'ItemLevel' compareOpNullable DIGITS;
poeDropLevel: 'DropLevel' compareOpNullable DIGITS;
poeQuality: 'Quality' compareOpNullable DIGITS;
poeWidth: 'Width' compareOpNullable DIGITS;
poeHeight: 'Height' compareOpNullable DIGITS;

statement:  poeClass
         |  poeFontSize 
         |  poeBackgroundColor
         |  poeBorderColor
         |  poeAlertSound
         |  poeSocketGroup
         |  poeRarity
         |  poeSockets
         |  poeItemLevel
         |  poeDropLevel
         |  poeLinkedSockets
         |  poeQuality
         |  poeBaseType
         |  poeWidth
         |  poeHeight
         |  poeTextColor;

block: visibility statement*?;
main: block+;
