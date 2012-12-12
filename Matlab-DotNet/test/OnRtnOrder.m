function OnRtnOrder(sender,arg)
disp(arg)

if arg.pOrder.VolumeTotal>2
    global td;
    % ³·µ¥
    td.CancelOrder(arg.pOrder);
end

end
