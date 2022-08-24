[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [PID_Parameter](../../PID_Parameter.md) > [Proportional_Band_Parameter](../Proportional_Band_Parameter.md) > [Supply_Air_Temperature_Proportional_Band_Parameter](Supply_Air_Temperature_Proportional_Band_Parameter.md) > [Heating_Supply_Air_Temperature_Proportional_Band_Parameter](.)
# Heating_Supply_Air_Temperature_Proportional_Band_Parameter

**Display name:** Heating Supply Air Temperature Proportional Band Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Heating_Supply_Air_Temperature_Proportional_Band_Parameter;1

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
