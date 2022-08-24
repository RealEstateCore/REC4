[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Limit](../../Limit.md) > [Max_Limit](../Max_Limit.md) > [Max_Air_Flow_Setpoint_Limit](#)
# Max_Air_Flow_Setpoint_Limit

**Display name:** Max Air Flow Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Max_Air_Flow_Setpoint_Limit;1

---


## Child interfaces
* [Max_Outside_Air_Flow_Setpoint_Limit](Max_Outside_Air_Flow_Setpoint_Limit.md)
* [Max_Cooling_Discharge_Air_Flow_Setpoint_Limit](Max_Cooling_Discharge_Air_Flow_Setpoint_Limit/Max_Cooling_Discharge_Air_Flow_Setpoint_Limit.md)
* [Max_Cooling_Supply_Air_Flow_Setpoint_Limit](Max_Cooling_Supply_Air_Flow_Setpoint_Limit/Max_Cooling_Supply_Air_Flow_Setpoint_Limit.md)
* [Max_Heating_Discharge_Air_Flow_Setpoint_Limit](Max_Heating_Discharge_Air_Flow_Setpoint_Limit/Max_Heating_Discharge_Air_Flow_Setpoint_Limit.md)
* [Max_Heating_Supply_Air_Flow_Setpoint_Limit](Max_Heating_Supply_Air_Flow_Setpoint_Limit/Max_Heating_Supply_Air_Flow_Setpoint_Limit.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
