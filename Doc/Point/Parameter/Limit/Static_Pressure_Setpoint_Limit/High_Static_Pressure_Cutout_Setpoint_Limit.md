[Point](../../../Point.md) > [Parameter](../../Parameter.md) > [Limit](../Limit.md) > [Static_Pressure_Setpoint_Limit](Static_Pressure_Setpoint_Limit.md) > [High_Static_Pressure_Cutout_Setpoint_Limit](.)
# High_Static_Pressure_Cutout_Setpoint_Limit

**Display name:** High Static Pressure Cutout Setpoint Limit<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Static_Pressure_Cutout_Setpoint_Limit;1

---
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
