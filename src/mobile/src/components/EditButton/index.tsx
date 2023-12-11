import React from 'react';
import { TouchableOpacity, GestureResponderEvent } from 'react-native';
import { useTheme } from 'styled-components';
import { PencilSimple } from 'phosphor-react-native';

type EditButtonProps = {
  onPress: (event: GestureResponderEvent) => void;
};

export const EditButton: React.FC<EditButtonProps> = ({ onPress }) => {
  const theme = useTheme();

  return (
    <TouchableOpacity onPress={onPress}>
      <PencilSimple size={32} color={theme.COLORS.GREEN_700} />
    </TouchableOpacity>
  );
};
