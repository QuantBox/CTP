function OnRtnOrder(sender,arg)
% ί�лر�

% ��ӡ����
disp(arg)

% ��ĳ������³������Լ����Ǹ�����
%if arg.pOrder.VolumeTotal>2
    global td;
    % ����
    td.CancelOrder(arg.pOrder);
%end

end
