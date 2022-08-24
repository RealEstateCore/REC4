[Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [Limit](../../../Limit.md) > [Min_Limit](../../Min_Limit.md) > [Min_Air_Flow_Setpoint_Limit](../Min_Air_Flow_Setpoint_Limit.md) > [Min_Heating_Supply_Air_Flow_Setpoint_Limit](Min_Heating_Supply_Air_Flow_Setpoint_Limit.md) > [Min_Unoccupied_Heating_Supply_Air_Flow_Setpoint_Limit](.)
# Min_Unoccupied_Heating_Supply_Air_Flow_Setpoint_Limit
**DTMI:** dtmi:org:brickschema:schema:Brick:Min_Unoccupied_Heating_Supply_Air_Flow_Setpoint_Limit;1
## Display name
- **en:** Min Unoccupied Heating Supply Air Flow Setpoint Limit
## Description
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
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