function OnMdConnect(sender,arg)
% �������ӻر�

% ����״̬��E_logined�ͱ�ʾ��¼�ɹ�
if arg.result == QuantBox.CSharp2CTP.ConnectionStatus.E_logined
    global md;
	% �������飬֧��","��";"�ָ�
    md.Subscribe('IF1305;IF1306,IF1309;IF1312');
end

end
