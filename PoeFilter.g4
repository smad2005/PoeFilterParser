grammar PoeFilter;


SOCKET: '"'[RGBW]+'"';
STR: '"'~["]*'"';
COMMENT: '#'.+?[\n] -> skip;
WS:    [ \t\r\n]+ -> skip ;
DIGITS: [0-9]+;
COMPAREOP:'='| '!='|'<'|'>'|'<='|'>=';
RARITY: 'Normal'| 'Magic'| 'Rare' | 'Unique';
SHOW: 'Show';
HIDE: 'Hide';

visibility: SHOW | HIDE;
params:STR (STR)*;
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
poeRarity: 'Rarity' COMPAREOP RARITY;
poeSocketGroup: 'SocketGroup' SOCKET;
poeLinkedSockets: 'LinkedSockets' COMPAREOP DIGITS;
poeSockets: 'Sockets' COMPAREOP DIGITS;
poeItemLevel: 'ItemLevel' COMPAREOP DIGITS;
poeDropLevel: 'DropLevel' COMPAREOP DIGITS;
poeQuality: 'Quality' COMPAREOP DIGITS;
poeWidth: 'Width' DIGITS;
poeHeight: 'Height' DIGITS;

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
