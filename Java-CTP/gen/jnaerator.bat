@echo off  
set dst=out.jar
set dll=QuantBox.C2CTP.dll
set inc= ThostFtdcUserApiDataType.h ThostFtdcUserApiStruct.h QuantBox.C2CTP.h
set sdk=QuantBox
set rt=JNA
java -jar jnaerator-0.11-shaded.jar -jar %dst% -library %sdk%  -runtime %rt% %dll% %inc% -mode Jar -noMangling