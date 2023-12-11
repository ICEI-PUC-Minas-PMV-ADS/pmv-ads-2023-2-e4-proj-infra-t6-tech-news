import { LogoStyle } from './styles';
import { useTheme } from 'styled-components/native';

export type LogoProps = {
  size?: number;
  color?: string;
};

export function Logo({ size = 56, color }: LogoProps) {
  const { COLORS } = useTheme();

  return <LogoStyle size={size} color={color ? color : COLORS.ORANGE_700} />;
}